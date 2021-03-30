using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DiacriticsRemover
{
    public static class DiacriticsMarksRemoval
    {
        public static string DiacriticsClearString(this string text)
        {
            //utilizando stringbuilder
            //StringBuilder stringRetunr = new StringBuilder();
            //var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            //foreach (char letter in arrayText)
            //{
            //    if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
            //    {
            //        stringRetunr.Append(letter);
            //    }
            //}
            //return stringRetunr.ToString();

            //array de comparacao
            //string withDiacritics = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            //string withoutDiacritics = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            //for (int i = 0; i < withDiacritics.Length; i++)
            //{
            //    text = text.Replace(withDiacritics[i].ToString(), withoutDiacritics[i].ToString());
            //}
            //return text;

            //utilizando LINQ
            //return new string(text
            //    .Normalize(NormalizationForm.FormD)
            //    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            //    .ToArray());

            //encoding
            //if (string.IsNullOrEmpty(text))
            //{
            //    return String.Empty;
            //}
            //byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(text);
            //return System.Text.Encoding.UTF8.GetString(bytes);

            StringBuilder stringRetunr = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                {
                    stringRetunr.Append(letter);
                }
            }
            return stringRetunr.ToString();
        }

        public static string DiacriticsClearString_sample2(string text)
        {
            string withDiacritics = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string withoutDiacritics = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            for (int i = 0; i < withDiacritics.Length; i++)
            {
                text = text.Replace(withDiacritics[i].ToString(), withoutDiacritics[i].ToString());
            }
            return text;
        }

        public static string DiacriticsClearString_sample3(this string text)
        {
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }

        public static string DiacriticsClearString_sample4(this string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return String.Empty;
            }
            byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(text);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }

        public static string DiacriticsClearString_sample5(this string text)
        {
            return text.RemoveDiacritics();
        }

        public static string DiacriticsClearString_sample6(string text)
        {
            return HttpUtility.UrlDecode(HttpUtility.UrlEncode(text, Encoding.GetEncoding("iso-8859-7")));
        }

        public static string DiacriticsClearString_sample7(this string source)
        {
            var encodeEightBit = Encoding.GetEncoding(1251).GetBytes(source);
            var stringSevenBits = Encoding.ASCII.GetString(encodeEightBit);
            var regex = new Regex("[^a-zA-Z0-9]=-_/");
            return regex.Replace(stringSevenBits, " ");
        }
    }
    }
}
