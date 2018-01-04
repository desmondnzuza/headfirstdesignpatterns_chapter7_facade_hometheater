namespace HomeTheater.HomeThreateFacade
{
    interface IHomeTheaterFacade
    {
        void WatchMovie(string movie);
        void EndMovie();
        void ListenToCd();
        void EndCd();
        void ListenToRadio();
        void EndRadio();
    }
}
