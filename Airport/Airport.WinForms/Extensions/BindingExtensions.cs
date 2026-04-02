using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
namespace Airport.WinForms.Extensions
{
    /// <summary>
    /// Класс с расширениями для биндинга данных в WinForms
    /// </summary>
    public static class BindingExtensions
    {
        /// <summary>
        /// Добавляет биндинг данных с возможностью валидации через ErrorProvider
        /// </summary>
        /// <typeparam name="TControl">Тип контрола</typeparam>
        /// <typeparam name="TSource">Тип источника данных</typeparam>
        /// <param name="control">Контрол, к которому применяется биндинг</param>
        /// <param name="targetProperty">Свойство контрола для привязки</param>
        /// <param name="source">Источник данных</param>
        /// <param name="sourceProperty">Свойство источника данных</param>
        /// <param name="errorProvider">Компонент для отображения ошибок валидации</param>
        public static void AddBinding<TControl, TSource>(
            this TControl control,
            Expression<Func<TControl, object>> targetProperty,
            TSource source,
            Expression<Func<TSource, object>> sourceProperty,
            ErrorProvider? errorProvider = null)
            where TControl : Control
            where TSource : class
        {
            var targetPropertyName = GetMemberName(targetProperty);
            var sourcePropertyName = GetMemberName(sourceProperty);

            control.DataBindings.Add(
                targetPropertyName,
                source,
                sourcePropertyName,
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            if (errorProvider != null)
            {
                control.Validating += (_, e) =>
                {
                    var property = source.GetType().GetProperty(sourcePropertyName);
                    var value = property?.GetValue(source);

                    var validationContext = new ValidationContext(source)
                    {
                        MemberName = sourcePropertyName
                    };

                    var validationResults = new List<ValidationResult>();

                    errorProvider.SetError(control, null);

                    if (!Validator.TryValidateProperty(value, validationContext, validationResults))
                    {
                        foreach (var error in validationResults)
                        {
                            errorProvider.SetError(control, error.ErrorMessage);
                        }
                        e.Cancel = true;
                    }
                };
            }
        }

        /// <summary>
        /// Получает имя свойства из лямбда-выражения
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="expression">Лямбда-выражение</param>
        /// <returns>Имя свойства</returns>
        private static string GetMemberName<T>(Expression<Func<T, object>> expression)
        {
            if (expression.Body is UnaryExpression unaryExpression)
            {
                var memberExpression = (MemberExpression)unaryExpression.Operand;
                return memberExpression.Member.Name;
            }

            var memberExp = (MemberExpression)expression.Body;
            return memberExp.Member.Name;
        }
    }
}
