using System;
using System.Linq;
using System.Windows.Markup;

namespace IlluminanceCalculation.Infrastructure
{
    public sealed class EnumMarkupExtension : MarkupExtension
    {
        private readonly Type _type;

        public EnumMarkupExtension(Type type)
        {
            _type = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(_type)
                .Cast<object>()
                .Select(e=>e.ToString());
        }
    }
}