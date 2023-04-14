using Image_Capture_Transmission_Class;
using System;
using System.Drawing;

namespace KMESendRecvLib
{
    public delegate void RecvKMEEventHandler(object sender, RecvKMEEventArgs e);
    public class RecvKMEEventArgs:EventArgs
    {
        public Meta Meta { get; private set; }
        public int Key { get { return Meta.Key; } }
        public Point Now { get { return Meta.Now; } }
        public MsgType MT { get { return Meta.MT; } }
        public RecvKMEEventArgs(Meta meta)
        {
            Meta = meta;
        }


    }
}
