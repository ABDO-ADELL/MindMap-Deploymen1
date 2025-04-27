namespace MindMap.Login_Register
{
    public class ChangeEmail
    {
        public string CurrentEmail { get; set; }  // البريد الإلكتروني الحالي للمستخدم
        public string Password { get; set; }   // كلمة المرور القديمة
        public string NewEmail { get; set; }      // البريد الإلكتروني الجديد
    }
}