namespace MindMap.Login_Register
{
    public class ChangeUserName
    {
        public string Email { get; set; }           // الإيميل لتحديد المستخدم
        public string Password { get; set; }        // كلمة السر للتحقق
        public string NewUserName { get; set; }     // الاسم الجديد
    }
}