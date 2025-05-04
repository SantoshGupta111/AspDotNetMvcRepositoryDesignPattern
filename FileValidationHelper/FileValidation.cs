using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileValidationHelper
{
    public class FileValidation
    {
        // For Image Upload: Check file extension
        public static bool IsValidImageExtension(string fileName)
        {
            string[] validImageExtensions = { ".bmp", ".jpg", ".png", ".gif", ".jpeg" };
            string fileExtension = Path.GetExtension(fileName).ToLower();

            return validImageExtensions.Contains(fileExtension);
        }

        // For Document Upload: Check file extension
        public static bool IsValidDocumentExtension(string fileName)
        {
            string[] validDocumentExtensions = { ".doc", ".docx", ".pdf", ".xls", ".xlsx" };
            string fileExtension = Path.GetExtension(fileName).ToLower();

            return validDocumentExtensions.Contains(fileExtension);
        }

        // Validate file size (in bytes)
        public static bool IsValidFileSize(long fileSize, long maxSizeInBytes)
        {
            return fileSize <= maxSizeInBytes;
        }


        // CreateRandomPassword Auto generate with Alpha+Numberic
        public static string CreateRandomPassword(int passwordLength)
        {
            const string allowedChars = "0123456789abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ";
            Random randNum = new Random();
            char[] chars = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                chars[i] = allowedChars[randNum.Next(allowedChars.Length)];
            }
            return new string(chars);
        }


        // Validate Email using System.Net.Mail
        public static bool IsValidEmailID(string _emailID)
        {
            if (string.IsNullOrEmpty(_emailID))
                return false;

            try
            {
                MailAddress mail = new MailAddress(_emailID);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Validate Email using Regex  
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        // Validate Mobile Number
        public static bool IsValidMobileNumber(string _mobileno)
        {
            if (string.IsNullOrEmpty(_mobileno))
                return false;

            string mobilePattern = @"^\d{10}$"; // Pattern for a 10-digit mobile number
            Regex regex = new Regex(mobilePattern);
            return regex.IsMatch(_mobileno);
        }

        //To use IFormFile in a class library, you must:
        //Add the necessary using Microsoft.AspNetCore.Http; in your class.

        //  now comment for some time. it used in only dot net core but need in dot net MVC only...

        ////public static string UploadFile(IFormFile file, string folderPath)
        ////{
        ////    if (file != null && file.Length > 0)
        ////    {
        ////        // Ensure the folder exists
        ////        string uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", folderPath);
        ////        if (!Directory.Exists(uploadPath))
        ////        {
        ////            Directory.CreateDirectory(uploadPath);
        ////        }

        ////        // Save the file
        ////        string filePath = Path.Combine(uploadPath, file.FileName);
        ////        using (var stream = new FileStream(filePath, FileMode.Create))
        ////        {
        ////            file.CopyTo(stream);
        ////        }

        ////        // Return the relative file path (for database storage)
        ////        return Path.Combine("uploads", folderPath, file.FileName).Replace("\\", "/");
        ////    }

        ////    return null; // Return null if no file was uploaded
        ////}



        public static string GenerateCaptchaText()
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var captcha = new StringBuilder();
            var random = new Random();

            for (int i = 0; i < 6; i++)
            {
                captcha.Append(chars[random.Next(chars.Length)]);
            }

            return captcha.ToString();
        }

    }
}



