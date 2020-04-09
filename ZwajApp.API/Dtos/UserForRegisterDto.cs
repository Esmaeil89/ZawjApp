using System.ComponentModel.DataAnnotations;

namespace ZwajApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(8,MinimumLength=4,ErrorMessage="يجب ان لا تزيد كلمة السر عن ثمانية احرف ولا تقل عن اربعة")]
        public string Password { get; set; }
    }
}