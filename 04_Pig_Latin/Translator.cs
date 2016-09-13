namespace _04_Pig_Latin {
    internal class Translator {
        public string Translate(string s) {
            string result = "";
            string IsVowel = "aeiouyAEIOUY";
            //QU exception's
            string exception = "qu";

            //for each word in string
            foreach (string word in s.Split(' ')) {
                //temporary word
                string tempWord = word;
                bool cap = false;
                
                //test if capitalized
                char tempChar = tempWord[0]; //get first letter
                if (tempChar == char.ToUpper(tempChar)) {
                    //remember that it was capitalized word
                    cap = true;
                    //remove capitalize 
                    tempWord = tempWord.ToLower();
                }

                //while word doesn't start on vowel
                while (IsVowel.IndexOf(tempWord.Substring(0, 1)) < 0) {
                    //if next to chars is "qu"
                    if (exception == tempWord.Substring(0, 2)) {
                        //add 1st and 2th letter to the end (aprently not in i sentance ??)
                        tempWord += tempWord[0]; 
                        tempWord += tempWord[1];
                        tempWord = tempWord.Substring(2); //remove two first letters
                    } else { //non "qu"
                        tempWord += tempWord[0]; //add 1st letter to the end
                        tempWord = tempWord.Substring(1); //remove first letter
                    }
                }

                //if word was captalized
                if (cap) {
                    tempChar = tempWord[0]; //new first letter
                    tempChar = char.ToUpper(tempChar); //Capitalize it     
                    tempWord = tempWord.Substring(1); //remove non capitalized start letter
                    tempWord = tempChar + tempWord; //insert capitalized start letter
                }

                //add "ay" when there is a vowel starting letter
                tempWord += "ay";
                //add word and a space to final result 
                result += tempWord + ' ';
            }

            //capitalize first + remove exess spaces
            return result.TrimEnd();
        }
    }
}