using System.Diagnostics.Eventing.Reader;

namespace Class.Alpha._1
{
    public static class User
    {
        //private members
        private static string _id;
        private static string _pw;
        private static Note _note;
        private static string _catalog;
        //public methods
        public static int SetId(string id)
        {
            throw new System.NotImplementedException();
            _id = id;
        } //Set id to Static, with error code return back.
        
        public static string GetId()
        {
            throw new System.NotImplementedException();
        } //Get id to local.
        
        public static int SetPw(string pw)
        {
            throw new System.NotImplementedException();
            _pw = pw;
        }
        
        public static int SetNote(Note note)
        {
            throw new System.NotImplementedException();
            _note = note;
        } //Set note to Static, with error code return back.
        
        public static string GetNote()
        {
            throw new System.NotImplementedException();
        } //Get note to local.

        public static int SetCatalog(string catalog)
        {
            throw new System.NotImplementedException();
            _catalog = catalog;
        } //Set catalog of video to Static, with error code return back.
        
        public static string GetCatalog()
        {
            throw new System.NotImplementedException();
        } //Get catalog of video to local.
    }

    interface IUserNet
    {
        int SentIdToServer(string id);
        int SentNoteToServer(string id, string note);
        int FetchNoteFromServer(string id);
    }
    
}