using System.Collections.Generic;

namespace Class.Alpha._1
{
    public class Video<T1,T2>
    {
        private string _catalog;
        private string _name;
        private List<string> _annotation;
        private List<string> _highLights;
        private T1 _video;
        private T2 _subtitles;
        public Video()
        {
            
        }

        public Video(string catalog)
        {
            _catalog = catalog;
        }

        #region public methods

        public int SetName(string name)
        {
            _name = name;
            throw new System.NotImplementedException();
        } //Set Video Name
        
        public string GetName()
        {
            throw new System.NotImplementedException();
        } //Get Video Name

        public int SetVideo(T1 video)
        {
            throw new System.NotImplementedException();
        } //Input Video from Resource File

        public T1 GetVideo()
        {
            throw new System.NotImplementedException();
        } //Using Video from RAM

        public int SetSubtitles(T2 subtitles)
        {
            throw new System.NotImplementedException();
        } //Input Subtitles

        public T2 GetSubtitles()
        {
            throw new System.NotImplementedException();
        } //Using Subtitles
        
        public int SetAnnotation(List<string> annotations)
        {
            throw new System.NotImplementedException();
        } //Set Annotation from Database

        public List<string> GetAnnotation()
        {
            throw new System.NotImplementedException();
        }
        
        public int SetHighLights(List<string> words)
        {
            throw new System.NotImplementedException();
            //Do something with subtitles
        } //HighLight Words in subtitles
        #endregion
    }

    interface IVideoNet
    {
        List<string> FetchHighLightFromServer(string catalog);
        List<string> FetchAnnotationFromServer(string catalog);
        int SendClickInfoToServer(string id, string videoName, string word);
    }
}