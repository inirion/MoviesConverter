using System;
using System.Diagnostics;
using System.IO;

namespace MoviesConverter
{
    class Converter
    {
        private Int32 _fps;
        public Int32 Fps
        {
            get { return _fps; }
            set { _fps = value; }
        }

        private Int32 _imageWidth;
        public Int32 ImageWidth
        {
            get { return _imageWidth; }
            set { _imageWidth = value; }
        }

        private Int32 _imageHeight;
        public Int32 ImageHeight
        {
            get { return _imageHeight; }
            set { _imageHeight = value; }
        }

        private Int32 _imageFlow;
        public Int32 ImageFlow
        {
            get { return _imageFlow; }
            set { _imageFlow = value; }
        }

        private Int32 _audioFlow;
        public Int32 AudioFlow
        {
            get { return _audioFlow; }
            set { _audioFlow = value; }
        }

        private string _container;
        public string Container
        {
            get { return _container; }
            set { _container = value; }
        }

        private string _outputFile;
        public string OutputFile
        {
            get{ return _outputFile; }
            set{ _outputFile = value; }
        }

        private string _inputFile;
        public string InputFile
        {
            get { return _inputFile; }
            set { _inputFile = value; }
        }

        private string _vlcPath;
        public string vlcPath
        {
            get { return _vlcPath; }
            set { _vlcPath = value; }
        }

        private string _videoCodec;
        public string VideoCoded
        {
            get { return _videoCodec; }
            set { _videoCodec = value; }
        }

        private string _audioCodec;
        public string AudioCodec
        {
            get { return _audioCodec; }
            set { _audioCodec = value; }
        }

        public long execute()
        {
            long beforeCompress = new System.IO.FileInfo(_inputFile).Length;
            Process p = new Process();
            p.StartInfo.FileName = _vlcPath;

            p.StartInfo.Arguments = "\"" + _inputFile + "\"" + " --sout=#transcode{vcodec="+ _videoCodec + 
                ",acodec=" + _audioCodec +",vb=" + _imageFlow+",ab="+_audioFlow +",height=" + _imageHeight+ 
                ",width=" + _imageWidth+ ",fps=" + _fps +"}:standard{access=file,mux=ts,dst=" + "\"" + _outputFile +
                "\"} vlc://quit";
            p.Start();
            p.WaitForExit();

            long afterCompress = new System.IO.FileInfo(_outputFile).Length;
            return beforeCompress - afterCompress;
        }
    }
}
