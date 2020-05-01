using System;
using System.Collections.Generic;
using System.Text;

namespace NodeStructure
{
	public class Samples
	{
        public const string TcpJson =
                    @"{
          ""$type"": ""Node.Defines.Defines.NodeGroups, Node.Defines"",
          ""Receivers"": {
            ""$type"": ""System.Collections.Generic.List`1[[Node.Defines.Nodes.Node, Node.Defines]], System.Private.CoreLib"",
            ""$values"": [
              {
                ""$type"": ""Samples.Receivers.Tcp, Nodes.Receivers.Tcp"",
                ""Host"": ""localhost"",
                ""Port"": 50934,
                ""Id"": ""129170f2-df56-4722-ab90-da81b5ce9f1e"",
                ""Name"": ""tcp receiver"",
                ""Type"": ""Samples.Receivers.Tcp"",
                ""Children"": {
                  ""$type"": ""System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",
                  ""$values"": [
                    ""1b42ff29-0d9a-4aac-9edc-391e436591b8""
                  ]
            },
                ""Position"": {
                  ""$type"": ""Node.Defines.Defines.NodePosition, Node.Defines"",
                  ""X"": 0.0,
                  ""Y"": 0.0
                }
              }
            ]
          },
          ""Executors"": null,
          ""Repeaters"": null
        }";

        //            @"{
        //    ""__type"": ""Node.Defines.Defines.NodeGroups, Node.Defines"",
        //    ""Receivers"": [{
        //            ""__type"": ""Samples.Receivers.Tcp, Nodes.Receivers.Tcp"",
        //            ""Host"": ""localhost"",
        //            ""Port"": 50934,
        //            ""Id"": ""3e5c1648-6953-42e5-83b2-3743e9e13cf4"",
        //            ""Name"": ""tcp receiver"",
        //            ""Type"": ""Samples.Receivers.Tcp"",
        //            ""Children"": [""422c0438-3d1f-4def-94c8-50797fb70c04""],
        //            ""Position"": ""Node.Defines.Defines.NodePosition""
        //        }
        //    ]
        //}";
        //        public const string TcpJson =
        //@"{
        //""$type"": ""Samples.Receivers.Tcp, Nodes.Receivers.Tcp"",
        //    ""Host"": ""localhost"",
        //    ""Port"": 50934,
        //    ""Id"": ""fd52eac7-430e-4923-a5d7-ffa0f01346eb"",
        //    ""Name"": ""tcp receiver"",
        //    ""Type"": ""Samples.Receivers.Tcp"",
        //    ""Children"": [""c83917d8-f0e8-4fba-aefa-ccee75efd476""],
        //    ""Position"": ""NodeStructure.Defines.NodePosition""
        //}";



        //@"{
        //          ""$type"": ""Samples.Receivers.Tcp, Nodes.Receivers.Tcp"",
        //          ""Host"": ""localhost"",
        //          ""Port"": 50934,
        //          ""Id"": ""54fa1df3-cee5-4b80-a904-6ea1f1655ecf"",
        //          ""Name"": ""tcp receiver"",
        //          ""Type"": ""Receivers.Tcp.Tcp"",
        //          ""Children"": [
        //            ""c674e9d4-5410-415d-a0bd-5a874dde3689""
        //          ],
        //          ""Position"": {
        //            ""$type"": ""Node.Defines.Defines.NodePosition, Node.Defines"",
        //            ""X"": 100.0,
        //            ""Y"": 0.100
        //          }
        //        }";


        //        public const string TcpJson =
        //@"
        //{
        //  ""$type"": ""Receivers.Tcp.Tcp, Receivers.Tcp"",
        //  ""Host"": ""localhost"",
        //  ""Port"": 50934,
        //  ""Id"": ""c7ced07c-a419-4aab-926e-27845fcb03ba"",
        //  ""Name"": ""tcp receiver"",
        //  ""Type"": ""Receivers.Tcp.Tcp"",
        //  ""Children"": {
        //    ""$type"": ""System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib"",
        //    ""$values"": [
        //      ""ff382240-019a-4951-8033-6bc806cb38a9""
        //    ]
        //    },
        //  ""Position"": {
        //    ""$type"": ""NodeStructure.Defines.NodePosition, NodeStructure"",
        //    ""X"": 0.0,
        //    ""Y"": 0.0
        //  }
        //}";
    }
}
