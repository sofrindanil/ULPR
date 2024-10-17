using System;

namespace DocumentManagement
{
    // Интерфейс для документов
    public interface IDocument
    {
        void FillContent(string content);
        void ShowContent();
        void Encrypt();
        void Decrypt();
    }

    // Абстрактный класс Document
    public abstract class Document : IDocument
    {
        protected string content;

        public Document()
        {
            content = string.Empty;
        }

        public Document(string content)
        {
            this.content = content;
        }

        // Заполнение содержимого
        public virtual void FillContent(string content)
        {
            this.content = content;
        }

        // Отображение содержимого
        public virtual void ShowContent()
        {
            Console.WriteLine("Document Content: " + content);
        }

        // Деструктор
        ~Document()
        {
            Console.WriteLine("Document is being destroyed.");
        }

        public abstract void Encrypt();
        public abstract void Decrypt();
    }

    // Класс EncryptedDocument, наследующий Document
    public class EncryptedDocument : Document
    {
        private bool isEncrypted = false;

        public EncryptedDocument() : base() { }

        public EncryptedDocument(string content) : base(content) { }

        public override void Encrypt()
        {
            if (!isEncrypted)
            {
                content = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
                isEncrypted = true;
                Console.WriteLine("Document encrypted.");
            }
            else
            {
                Console.WriteLine("Document is already encrypted.");
            }
        }

        public override void Decrypt()
        {
            if (isEncrypted)
            {
                content = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(content));
                isEncrypted = false;
                Console.WriteLine("Document decrypted.");
            }
            else
            {
                Console.WriteLine("Document is not encrypted.");
            }
        }

        public override void ShowContent()
        {
            if (isEncrypted)
            {
                Console.WriteLine("Document Content: [Encrypted]");
            }
            else
            {
                base.ShowContent();
            }
        }

        // Деструктор
        ~EncryptedDocument()
        {
            Console.WriteLine("EncryptedDocument is being destroyed.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter document content:");
            string userInput = Console.ReadLine();

            // Создаем документ
            Document doc = new EncryptedDocument(userInput);

            // Заполняем и отображаем содержимое
            doc.ShowContent();

            // Шифруем документ
            doc.Encrypt();
            doc.ShowContent();

            // Дешифруем документ
            doc.Decrypt();
            doc.ShowContent();

            // Завершение работы программы
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}