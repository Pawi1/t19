﻿class HomeTheatrFacade
    {
        public void watchmovie() { }
        public void endMovie() { }
        projector projector;
        SoundSystem sound;
        MediaPlayer player;

        public void cosProjektor()
        {
            projector = new projector();
        }
        public void cosDzwiek()
        {
            sound = new SoundSystem();
        }
        public void setMediaPlayer(MediaPlayer media)
        {
            this.player = media;
        }

    }
    class projector
    {
        public void on() { }
        public void off() { }
    }
class SoundSystem
    {
        public void on() { }
        public void off() { }
    }
class MediaPlayer
    {
        public void play() { }
        public void stop() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
