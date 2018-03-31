namespace QuickGraph.Graphviz.Dot
{
    using System;

    public class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }

    /// <summary>
    ///     Contains all the output formats supported by GraphViz as in <see href="http://www.graphviz.org/doc/info/output.html" />.
    /// </summary>
    public enum GraphvizImageType
    {
        [Description("Figure format")] Fig = 0,
        [Description("Gd format")] Gd = 1,
        [Description("Gd2 format")] Gd2 = 2,
        [Description("GIF format")] Gif = 3,
        [Description("HP-GL/2 format")] Hpgl = 4,
        [Description("Server-side imagemaps")] Imap = 5,
        [Description("Client-side imagemaps Format (deprecated)")] Cmap = 6,
        [Description("JPEG format")] Jpeg = 7,
        [Description("FrameMaker MIF format")] Mif = 8,
        [Description("MetaPost")] Mp = 9,
        [Description("PCL format")] Pcl = 10,
        [Description("Kernighan's PIC Graphics Language Format")] Pic = 11,
        [Description("Plain Text format")] PlainText = 12,
        [Description("Portable Network Graphics format")] Png = 13,
        [Description("Postscript")] Ps = 14,
        [Description("PostScript for PDF")] Ps2 = 15,
        [Description("Scalable Vector Graphics")] Svg = 0x10,
        [Description("Scalable Vector Graphics, gzipped")] Svgz = 0x11,
        [Description("VRML")] Vrml = 0x12,
        [Description("Visual Thought format")] Vtx = 0x13,
        [Description("Wireless BitMap format")] Wbmp = 20,
        [Description("Windows Bitmap Format")] Bmp = 21,
        [Description("DOT Format")] Canon = 22,
        [Description("DOT Format")] Gv = 23,
        [Description("DOT Format")] Xdot = 24,
        [Description("DOT Format")] Xdot12 = 25,
        [Description("DOT Format")] Xdot14 = 26,
        [Description("CGImage bitmap Format")] Cgimage = 27,
        [Description("Encapsulated PostScript Format")] Eps = 28,
        [Description("OpenEXR Format")] Exr = 29,
        [Description("GTK Canvas Format")] Gtk = 30,
        [Description("Icon Image File Format")] Ico = 31,
        [Description("Client-side imagemaps Format")] Cmapx = 32,
        [Description("Server-side imagemaps Format")] ImapNp = 33,
        [Description("Client-side imagemaps Format")] CmapxNp = 34,
        [Description("Server-side imagemaps Format (deprecated)")] Ismap = 35,
        [Description("JPEG 2000 Format")] Jp2 = 36,
        [Description("JPEG Format")] Jpg = 37,
        [Description("JPEG Format")] Jpe = 38,
        [Description("Dot Graph Represented in JSON Format")] Json = 39,
        [Description("Dot Graph Represented in JSON Format")] Json0 = 40,
        [Description("Dot Graph Represented in JSON Format")] DotJson = 41,
        [Description("Dot Graph Represented in JSON Format")] XdotJson = 42,
        [Description("PICT Format")] Pict = 43,
        [Description("PICT Format")] Pct = 44,
        [Description("Portable Document Format (PDF) Format")] Pdf = 45,
        [Description("Plain-text Format")] Plain = 46,
        [Description("Plain-text Format")] PlainExt = 47,
        [Description("POV-Ray Markup Language (prototype) Format")] Pov = 48,
        [Description("PSD Format")] Psd = 49,
        [Description("SGI Format")] Sgi = 50,
        [Description("Truevision TGA Format")] Tga = 51,
        [Description("Tag Image File Format (TIFF) Format")] Tif = 52,
        [Description("Tag Image File Format (TIFF) Format")] Tiff = 53,
        [Description("TK Graphics Format")] Tk = 54,
        [Description("Vector Markup Language (VML) Format")] Vml = 55,
        [Description("Vector Markup Language (VML) Format")] Vmlz = 56,
        [Description("Image format for the Web Format")] Webp = 57,
        [Description("Xlib Canvas Format")] Xlib = 58,
        [Description("Xlib Canvas Format")] X11 = 59
    }

    public static class Extensions
    {
        #region Public Methods

        /// <summary>
        ///     Gets the output format string of the given <see cref="GraphvizImageType" /> to be used for GraphViz command-line
        ///     conversion.
        /// </summary>
        /// <param name="imageType">The image type we want to get the output format.</param>
        /// <returns>
        ///     The output format string of the given <see cref="GraphvizImageType" /> to be used for GraphViz command-line
        ///     conversion.
        /// </returns>
        public static string GetOutputFormatStr(this GraphvizImageType imageType)
        {
            switch (imageType)
            {
                case GraphvizImageType.Fig:
                    return "fig";
                case GraphvizImageType.Gd:
                    return "gd";
                case GraphvizImageType.Gd2:
                    return "gd2";
                case GraphvizImageType.Gif:
                    return "gif";
                case GraphvizImageType.Hpgl:
                    return "hpgl";
                case GraphvizImageType.Imap:
                    return "imap";
                case GraphvizImageType.Cmap:
                    return "cmap";
                case GraphvizImageType.Jpeg:
                    return "jpeg";
                case GraphvizImageType.Mif:
                    return "mif";
                case GraphvizImageType.Mp:
                    return "mp";
                case GraphvizImageType.Pcl:
                    return "pcl";
                case GraphvizImageType.Pic:
                    return "pic";
                case GraphvizImageType.PlainText:
                    return "plaintext";
                case GraphvizImageType.Png:
                    return "png";
                case GraphvizImageType.Ps:
                    return "ps";
                case GraphvizImageType.Ps2:
                    return "ps2";
                case GraphvizImageType.Svgz:
                    return "svgz";
                case GraphvizImageType.Vrml:
                    return "vrml";
                case GraphvizImageType.Vtx:
                    return "vtx";
                case GraphvizImageType.Wbmp:
                    return "wbmp";
                case GraphvizImageType.Bmp:
                    return "bmp";
                case GraphvizImageType.Canon:
                    return "fig";
                case GraphvizImageType.Gv:
                    return "gv";
                case GraphvizImageType.Xdot:
                    return "xdot";
                case GraphvizImageType.Xdot12:
                    return "xdot1.2";
                case GraphvizImageType.Xdot14:
                    return "dot1.4";
                case GraphvizImageType.Cgimage:
                    return "cgimage";
                case GraphvizImageType.Eps:
                    return "eps";
                case GraphvizImageType.Exr:
                    return "exr";
                case GraphvizImageType.Gtk:
                    return "gtk";
                case GraphvizImageType.Ico:
                    return "ico";
                case GraphvizImageType.Cmapx:
                    return "cmapx";
                case GraphvizImageType.ImapNp:
                    return "imap_np";
                case GraphvizImageType.CmapxNp:
                    return "cmapx_np";
                case GraphvizImageType.Ismap:
                    return "ismap";
                case GraphvizImageType.Jp2:
                    return "jp2";
                case GraphvizImageType.Jpg:
                    return "jpg";
                case GraphvizImageType.Jpe:
                    return "jpe";
                case GraphvizImageType.Json:
                    return "json";
                case GraphvizImageType.Json0:
                    return "json0";
                case GraphvizImageType.DotJson:
                    return "dot_json";
                case GraphvizImageType.XdotJson:
                    return "xdot_json";
                case GraphvizImageType.Pict:
                    return "pict";
                case GraphvizImageType.Pct:
                    return "pct";
                case GraphvizImageType.Pdf:
                    return "pdf";
                case GraphvizImageType.Plain:
                    return "plain";
                case GraphvizImageType.PlainExt:
                    return "plain-ext";
                case GraphvizImageType.Pov:
                    return "pov";
                case GraphvizImageType.Psd:
                    return "psd";
                case GraphvizImageType.Sgi:
                    return "sgi";
                case GraphvizImageType.Tga:
                    return "tga";
                case GraphvizImageType.Tif:
                    return "tif";
                case GraphvizImageType.Tiff:
                    return "tiff";
                case GraphvizImageType.Tk:
                    return "tk";
                case GraphvizImageType.Vml:
                    return "vml";
                case GraphvizImageType.Vmlz:
                    return "vmlz";
                case GraphvizImageType.Webp:
                    return "webp";
                case GraphvizImageType.Xlib:
                    return "xlib";
                case GraphvizImageType.X11:
                    return "x11";
                case GraphvizImageType.Svg:
                default:
                    return "svg";
            }
        }

        #endregion
    }

   
}

