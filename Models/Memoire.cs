using platformApp.Models;

namespace Memoireclass.Models
{
    public class Memoire
    {
        public int MemoireID { get; set; }
        public string Title { get; set; }
        public string Field { get; set; }
        public string Keywords { get; set; }
        public DateTime Date { get; set; }
        public int ProfessorID { get; set; }
        public string FilePath { get; set; }
        public string AuthorName { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorPicturePath { get; set; }

     public User Professor { get; set; }
    // public ICollection<Favorite> Favorites { get; set; }
    // public ICollection<Comment> Comments { get; set; }
    }
}
