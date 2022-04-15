//宣告選項字串(election)、輸入字串(textbox)和判斷是否填過一次的布林(start)。
//字串是由0開始算，所以下面輸入字串的名字是0，性別是1，出生年月日是2，學號是3
//但總共有4個，所以下面的輸入字串總長度打4
//字串方便修改與增加等，不想用字串也可以分開宣告，但就很麻煩。
string[] selection= new string[]{"名字","性別(1.男  2.女)","出生年月日","學號"};
string[] textbox=new string[4];
bool start = true;

//宣告重複字串
String Repeat = "1";

//void宣告函數 只要寫一次 方便跟可閱讀性高 日後需使用可直接Display();
//若不想宣告，後面只要出現Display的地方都要改成裡面的for迴圈。
//用來顯示結果用。
void Display()
{
    for(int a=0;a<4;a++)
    {
        Console.WriteLine(selection[a]+":"+ textbox[a]);

    }

};
Console.WriteLine("Homework5 基本資料輸入系統");
while(Repeat=="1")
{
//重置是否填寫
start = true;

//使用IF內包FOR迴圈第一次詢問數值，若未打數值則進入While迴圈再次詢問。
if(start==true)
{
    for(int a=0;a<4;a++)
    {
        Console.WriteLine("請輸入" +selection[a]);
        textbox[a]=Console.ReadLine();

        while(textbox[a] == null)
        {
            Console.WriteLine("請輸入數值。");
            textbox[a]=Console.ReadLine();
        }
    }
    //並將start布林數設為false，以進入是否正確階段。
    start = false;
};




while(start==false)
{
    //使用者輸入完全數值後，調用Display函數，顯示全部數值。
    switch(textbox[1])
    {
        case"1":
            textbox[1] ="男";
            break;
        case"2":
            textbox[1] ="女";
            break;
        default:
            textbox[1] ="不知名性別";
            break;
    };
    Display();
    Console.WriteLine("正確請按1，錯誤請按2。");
    //宣告確認是否正確整數(end)，判斷是否正確。
    String end = Console.ReadLine();
    //若end=1，資料正確，使用break結束函數。
    //由於start永遠=false，不會離開這個迴圈，所以必須打break，(打reture會直接結束整個程式，但我要出去外面。)
    if(end == "1")
    {
        Console.WriteLine("已完成資料建置，感謝您的填寫。");
        break;
    }
    else if(end == "2")
    {
        //宣告x判斷欲修改欄位。
        //for迴圈顯示修改選項
        int x;
        Console.WriteLine("請選擇欲重新填寫欄位");
        for(int i = 0 ; i <4 ;i++)
        {
            Console.WriteLine("("+(i+1)+")"+selection[i]);
        }
        Console.WriteLine("(其他)回到上一步");
        //使用int.parse(Console.ReadLine())讓使用者填入要修改東西
        //因為是int 不能直接Readline 藥用int.parse轉成int。
        x = int.Parse(Console.ReadLine());
         //用if判斷數值是否在1-4(修改選項)，執行修改。
         //若數值不再1-4則出去此else if。
        if(0<x && x<=selection.Length)
        {
            Console.WriteLine("更改"+selection[x-1]);
            textbox[x-1] = Console.ReadLine();
             while(textbox[x-1] == null)
            {
                Console.WriteLine("更改"+selection[x-1]);
                textbox[x-1] = Console.ReadLine();
            }
            
        }

    }
    //若使用者亂打，則叫使用者在打一次
    else
    {
        Console.WriteLine("請打出正確選項。");
    }

};
//填寫成功，1可重填(因為最外層的While條件為repeat==1)，其他可以結束
Console.WriteLine("欲全部重新填寫請按1，結束程式請按其他。");
Repeat= Console.ReadLine();
};



