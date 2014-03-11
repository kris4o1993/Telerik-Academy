using System.Text;
namespace _01_Substring
{
    public static class SubstringSb
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            char[] sbToCharArray = sb.ToString().ToCharArray();
            int count = sbToCharArray.Length;

            for (int i = index; i < index + length; i++)
            {
                result.Append(sbToCharArray[i]);
            }

            return result;
        }
    }
}
