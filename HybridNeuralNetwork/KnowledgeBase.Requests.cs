
namespace HybridNeuralNetwork
{
    public partial class KnowledgeBase
    {
        private static string GetRequests(string s_NameRequest, string s_Name = "")
        {
            switch (s_NameRequest)
            {
                case "getfirstlayer":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?layer WHERE
                            {?layer a pr:inputLayer.
                            }";
                case "getnextlayer":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?layer WHERE
                            {?layer pr:nextLayer "+s_Name+@".
                            }";
                case "getinputnodesnet":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?input ?label WHERE
                            {?input pr:input " + s_Name + @".
                                ?input rdfs:label ?label.
                            }";
                case "getoutputnodes":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?output ?label WHERE
                            {?output pr:output " + s_Name + @".
                                ?output rdfs:label ?label.
                            }";
                case "getlinkednodes":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?linked ?label WHERE
                            {?linked pr:referTo " + s_Name + @".
                                ?linked rdfs:label ?label.
                            }";
                case "getoperator":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?operator WHERE
                            {?operator pr:operator " + s_Name + @".
                            }";
                case "getvalue":
                    return @"
                            prefix cl: <URN:classes:stock>
                            prefix pr: <URN:properties:stock>
                            prefix ins: <URN:instanses:stock>
                            prefix owl:<http://www.w3.org/2002/07/owl#>
                            prefix rdf:<http://www.w3.org/1999/02/22-rdf-syntax-ns#>
                            prefix rdfs:<http://www.w3.org/2000/01/rdf-schema#>

                            SELECT ?value WHERE
                            {"+ s_Name+ @" pr:value ?value.
                            }";
                default:
                    return "";
            }
        }
    }
}
