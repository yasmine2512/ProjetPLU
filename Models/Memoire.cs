namespace Memoireclass.Models
{
    public class Memoire
    {
        public int MemoireID { get; set; }
        public string Title { get; set; }
        public string Field { get; set; }
        public string Keywords { get; set; }
        public DateTime Date { get; set; }
        public string FilePath { get; set; }
        public string AuthorName { get; set; }
    }
}
