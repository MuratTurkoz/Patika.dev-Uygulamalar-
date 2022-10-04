namespace Proje_2_TODO_Uygulaması
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Person Person { get; set; }
        public Size Size { get; set; }
        public BoardType BoardType { get; set; }
    }
    public enum BoardType
    {
        TODO = 0,
        INPROGRESS = 1,
        DONE = 2

    }
    public enum Size
    {
        XS = 1, S = 2, M = 3, L = 4, XL = 5

    }

}