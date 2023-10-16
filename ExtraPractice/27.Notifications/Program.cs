namespace _27.Notifications
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            void ShowSuccessMessage(string operation, string message)
            {
                string successMessage = $"Successfully executed {operation}.";
                Console.WriteLine(successMessage);
                for (int i = 1; i <= successMessage.Length; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                Console.WriteLine($"{message}.");
            }

            void ShowWarningMessage(string message)
            {
                string warningMessage = $"Warning: {message}.";
                Console.WriteLine(warningMessage);
                for (int i = 1; i <= warningMessage.Length; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }

            void ShowErrorMessage(string operation, string message, int errorCode)
            {
                string errorMessage = $"Error: Failed to execute {operation}.";
                Console.WriteLine(errorMessage);
                for (int i = 1; i <= errorMessage.Length; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();

                Console.WriteLine($"Reason: {message}.");
                Console.WriteLine($"Error code: {errorCode}.");
            }

            void ReadAndProcessMessage(string type)
            {
                if (type == "success")
                {
                    string userOperation = Console.ReadLine();
                    string userMessage = Console.ReadLine();
                    ShowSuccessMessage(userOperation, userMessage);
                }
                if (type == "warning")
                {
                    string userMessage = Console.ReadLine();
                    ShowWarningMessage(userMessage);
                }
                if (type == "error")
                {
                    string userOperation = Console.ReadLine();
                    string userMessage = Console.ReadLine();
                    int userErrorCode = int.Parse(Console.ReadLine());
                    ShowErrorMessage(userOperation, userMessage, userErrorCode);
                }
            }

            int numMessages = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numMessages; i++)
            {
                string userType = Console.ReadLine();
                ReadAndProcessMessage(userType);
                Console.WriteLine();
            }

        }
    }
}