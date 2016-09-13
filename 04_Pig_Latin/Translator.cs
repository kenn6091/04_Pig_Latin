namespace _04_Pig_Latin {
    internal class Translator {
        public string Translate(string s) {
            string result = "";
            string IsVowel = "aeioyAEIOY"; //mangler QU untagelsen så derfor ikke "u" her enddu

            //for each word in string
            foreach (string word in s.Split(' ')) {
                //temporary word
                string tempWord = word;
                
                //while word doesn't start on vowel
                while (IsVowel.IndexOf(tempWord.Substring(0, 1)) < 0) { 
                    tempWord += tempWord[0]; //add first letter to the end
                    tempWord = tempWord.Substring(1); //remove first letter
                }
                //add "ay" når der ik er flere konsonanter i starten af ordet
                tempWord += "ay";
                //add word and a space to final result 
                result += tempWord + ' ';
            }

            //return + remove exess spaces
            return result.TrimEnd();
        }
    }
}