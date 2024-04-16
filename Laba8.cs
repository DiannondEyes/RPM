namespace RPM {
    public class PasswordManager<T> : ArrayStorage<T> {
        Dictionary<string, T> passwords = [];
        public void AddItem(string login, T password) {
            passwords.Add(login, password);
        }

        public void RemoveItem(string login) {
            passwords.Remove(login);
        }

        public T GetPassword(string login) {
            return passwords[login];
        }

        public int GetPasswordsLength() {
            return passwords.Count;
        }
    }

    public class Laba8 {
        public static void Run() {
            PasswordManager<int> PassMan = new();
            PassMan.AddItem("vasya", 123);
            PasswordManager<string> StringPassMan = new();
            StringPassMan.AddItem("petya", "qwerty123");
            Console.WriteLine(StringPassMan.GetPassword("petya"));
        }
    }
}