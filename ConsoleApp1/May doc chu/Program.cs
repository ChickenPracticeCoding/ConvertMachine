namespace May_doc_chu
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Nhập một số nguyên từ 20 trở lên (20-39): ");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int number);

                if (isValid && number >= 20 && number < 40)
                {
                    string result = ConvertNumberToWords(number);
                    Console.WriteLine($"Số {number} đọc là: {result}");
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập một số hợp lệ trong khoảng từ 20 đến 39.");
                }
            }

            public static string ConvertNumberToWords(int number)
            {
                // Mảng chữ số từ 0 đến 9
                string[] units = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };

                // Lấy chữ số hàng chục và hàng đơn vị
                int tens = number / 10;  // Số hàng chục
                int unitsDigit = number % 10; // Số hàng đơn vị

                string result = "";

                // Kiểm tra hàng chục
                if (tens == 2)
                {
                    result += "hai mươi"; // Hàng chục là 2
                }
                else if (tens == 3)
                {
                    result += "ba mươi"; // Hàng chục là 3
                }
                //... Tương tự với các số 40 -99
                // Kiểm tra hàng đơn vị
                if (unitsDigit > 0)
                {
                    // Nối thêm chữ số hàng đơn vị nếu khác 0
                    result += " " + units[unitsDigit];
                }



                return result;
            }
        }
    }
