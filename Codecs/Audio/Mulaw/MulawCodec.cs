﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.Codecs.Audio.Mulaw
{
    public class MulawCodec : IAudioCodec //: Media.Codec.Codec
    {
        public const string Name = "MuLaw";

        public static readonly System.Guid Id;

        static MulawCodec()
        {
            Id = Media.Codec.Codec.ParseGuidAttribute(typeof(MulawCodec));

            Media.Codec.Codecs.TryRegisterCodec(new MulawCodec());
        }

        System.Guid Codec.Interfaces.ICodec.Id
        {
            get { return MulawCodec.Id; }
        }

        string Codec.Interfaces.ICodec.Name
        {
            get { return MulawCodec.Name; }
        }

        Codec.MediaType Codec.Interfaces.ICodec.MediaTypes
        {
            get { return Codec.MediaType.Audio; }
        }

        bool Codec.Interfaces.ICodec.CanEncode
        {
            get { return true; }
        }

        bool Codec.Interfaces.ICodec.CanDecode
        {
            get { return true; }
        }


        Codec.Interfaces.IEncoder Codec.Interfaces.ICodec.Encoder
        {
            get { return new MuLawEncoder(); }
        }

        Codec.Interfaces.IDecoder Codec.Interfaces.ICodec.Decoder
        {
            get { return new MuLawDecoder(); }
        }
    }
}
