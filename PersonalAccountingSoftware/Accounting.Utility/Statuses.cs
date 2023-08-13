namespace Accounting.Utility
{
    public static class Statuses
    {
        //For Messages
        public const byte Success = 1;
        public const byte Error = 2;
        public const byte DuplicatedRecord = 3;
        public const byte UserNotFound = 4;
        public const byte PasswordNotMatch = 5;
        public const byte RequiredCombobox = 6;
        public const byte UnauthorizedEntry = 7;
        public const byte CurrentPasswordIsNotCorrect = 8;
        public const byte AdminIsNotBlocked = 9;
        public const byte SelectNewPassword = 10;
        //...

        public const bool Remove = true;
        public const bool Restore = false;
        public const bool Removed = true;
        public const bool NotRemoved = false;

        public const byte UnRemoved = 0;

        public const bool Block = true;
        public const bool UnBlock = false;
        public const bool Blocked = true;
        public const bool NotBlocked = false;

        public const byte Cost = 1;
        public const byte Income = 2;

        public const byte AdminSystem = 1;
        public const byte UserSystem = 2;
    }
}