namespace Proje_2_TODO_Uygulaması
{
    public interface IBoardManagement
    {
        void GetBoardList();
        void ShowBoard();
        void AddCardToBoard();
        void DeleteCardToBoard();
        void MoveCardToBoard();
        void ToWork(int res);
    }
}