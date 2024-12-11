using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace PizzaShop.Api.Utilities
{
    public static class EnumExtensions
    {
        public static string GetDescriptionAttributeFromEnum(this Enum enumValue, Type enumType)
        {
            string description = string.Empty;
            MemberInfo info = enumType.GetMember(enumValue.ToString()).First();

            if (info != null && info.CustomAttributes.Any())
            {
                DescriptionAttribute descriptionAttr = info.GetCustomAttribute<DescriptionAttribute>();
                description = (descriptionAttr != null ? descriptionAttr.Description : enumValue.ToString()) ?? string.Empty;
            }
            else
            {
                description = enumValue.ToString();
            }
            return description;
        }
    }
}
