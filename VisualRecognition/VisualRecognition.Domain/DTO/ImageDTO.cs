using System;

namespace VisualRecognition.Domain.DTO
{
    public class ImageDTO
    {
        public string LastModified { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string WebKitRelativePath { get; set; }
        //        lastModified: 1560704659829
        //lastModifiedDate: Sun Jun 16 2019 14:04:19 GMT-0300 (Horário Padrão de Brasília) {}
        //name: "640px-IBM_VGA_90X8941_on_PS55.jpg"
        //size: 88571
        //type: "image/jpeg"
        //webkitRelativePath: ""
    }
}
