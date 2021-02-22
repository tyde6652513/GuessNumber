using System;
namespace DefineNumber
{
    class Number
    {
        private string _RightAnswer,_UserAnswer;
        
        public string RightAnswer
        {
            get{return _RightAnswer;}
            set{
                _RightAnswer = value;
            }
        }
        public string UserAnswer
        {
            get{return _UserAnswer;}
            set{_UserAnswer = value;}
        }
        public void CreateAnswer()
        {
            int[] temp = new int[4];
            Random R = new Random();
            for (int j = 0;j<4;j++)
            {
                if (j == 0){
                    temp[j] = R.Next(0,10);
                }
                else{
                    temp[j] = R.Next(0,10);
                    for (int k = 0;k<j;k++)
                    {
                        if (temp[k] == temp[j]){
                            j--;
                            break;
                        }
                    }
                }         
            }
            RightAnswer = string.Concat(temp);
        }
        public int GetA()
        {
            int FlagA = 0;
            for (int i = 0;i<UserAnswer.Length;i++){
                if(UserAnswer[i] == RightAnswer[i]){
                    FlagA++;
                }
            }
            return FlagA;
        }
        public int GetB()
        {
            int FlagB = 0;
            for (int i = 0;i<RightAnswer.Length;i++){
                for(int j = 0;j<RightAnswer.Length;j++){
                    if ((i != j) && (UserAnswer[i] == RightAnswer[j])){
                        FlagB++;
                        break;
                    }
                }
            }
            return FlagB;
        }
        public bool CheckFormat() 
        {
            bool Bflag = true;
            int SameFlag;
            if (UserAnswer.Length == 4)
            {               
                for (int i = 0; i < UserAnswer.Length; i++)
                {
                    if ((Convert.ToInt16(UserAnswer[i]) > 57) | (Convert.ToInt16(UserAnswer[i]) < 48))
                    {
                        Bflag = false;
                    }
                    else
                    {
                        SameFlag = 0;
                        for (int j = 0; j < UserAnswer.Length; j++)
                        {
                            if (UserAnswer[i] == UserAnswer[j])
                            {
                                SameFlag++;
                            }
                            if (SameFlag > 1)
                            {
                                Bflag = false;
                                break;
                            }
                        }
                    }
                    if (!Bflag) break;
                }
                return Bflag;
            }
            else
            {
                return false;
            }
        }
    }
}
