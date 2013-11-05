using System.Collections.Generic;

namespace NhaNhaNha
{
    public class Valores
    {
        public static Dictionary<string, TextoLorem> Texto = new Dictionary<string, TextoLorem>
        {
            {
                "Lorem", new TextoLorem
                {
                    ComecoPadrao = "Lorem ipsum dolor sit amet",
                    Palavras =
                        new[]
                        {
                            "lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit", "ut", "orci",
                            "scelerisque", "tempor", "elementum", "et", "dictum", "quis", "massa", "sed", "sollicitudin",
                            "mi", "nec", "semper", "molestie", "pellentesque", "fermentum", "libero", "vel", "arcu",
                            "eu", "ante", "aliquam", "nam", "posuere", "mauris", "a", "vehicula", "dignissim", "tortor",
                            "tincidunt", "ligula", "ultricies", "imperdiet", "velit", "est", "cras", "luctus",
                            "ullamcorper", "leo", "in", "accumsan", "nunc", "blandit", "fusce", "turpis", "dui",
                            "sagittis", "purus", "metus", "vitae", "ac", "laoreet", "enim", "nulla", "mattis", "etiam",
                            "euismod", "fringilla", "felis", "augue", "viverra", "duis", "facilisis", "urna", "ornare",
                            "non", "tempus", "integer", "risus", "diam", "quam", "vulputate", "at", "dapibus", "gravida",
                            "aenean", "hac", "habitasse", "platea", "dictumst", "eros", "tellus", "volutpat", "id",
                            "vestibulum", "cursus", "rutrum", "magna", "sapien", "hendrerit", "eget", "donec", "sem",
                            "interdum", "varius", "nisi", "odio", "nibh", "class", "aptent", "taciti", "sociosqu", "ad",
                            "litora", "torquent", "per", "conubia", "nostra", "inceptos", "himenaeos", "feugiat",
                            "malesuada", "praesent", "ultrices", "neque", "tristique", "rhoncus", "facilisi",
                            "convallis", "phasellus", "sodales", "quisque", "faucibus", "proin", "suspendisse", "congue",
                            "maecenas", "auctor", "condimentum", "justo", "porttitor", "iaculis", "lobortis", "aliquet",
                            "suscipit", "primis", "cubilia", "curae", "cum", "sociis", "natoque", "penatibus", "magnis",
                            "dis", "parturient", "montes", "nascetur", "ridiculus", "mus", "pulvinar", "lacinia", "erat",
                            "nisl", "venenatis", "nullam", "lectus"
                        }
                }
            },
            {
                "Bancon", new TextoLorem
                {
                    ComecoPadrao = "Bacon ipsum dolor sit amet",
                    Palavras =
                        new[]
                        {
                            "jowl", "chicken", "boudin", "doner", "turkey", "drumstick", "swine", "prosciutto", "ham",
                            "andouille", "ribeye", "tail", "pig", "spare", "ribs", "leberkas", "ball", "tip", "capicola",
                            "sirloin", "brisket", "jerky", "meatloaf", "cow", "pork", "chop", "tri-tip", "venison",
                            "loin", "biltong", "shankle", "shank", "pastrami", "pancetta", "meatball", "ground", "round",
                            "hamburger", "bacon", "strip", "steak", "shoulder", "chuck", "beef", "sausage",
                            "turduckenfatback", "tenderloin", "tongue", "kielbasa", "corned", "filet", "mignon",
                            "donerham", "hock", "rump", "flank", "short", "t-bone", "belly", "fatbackstrip", "turducken",
                            "hamburgerchicken", "frankfurter", "fatback", "fatbackjowl", "salami", "roundhamburger",
                            "sausagesalami", "bresaola", "sausaget-bone", "pigprosciutto", "hockfilet", "fatbacksalami",
                            "chopspare", "chopjowl", "jowlpancetta", "bresaoladoner", "tipshankle", "tipbrisket",
                            "venisonham", "bellybrisket", "sausagesausage", "tipbeef", "t-bonepastrami",
                            "frankfurterbacon", "capicolasirloin", "beefground", "chuckribeye", "salamiswine",
                            "shouldertri-tip", "cowshort", "t-bonebeef", "turduckensausage", "bellysalami",
                            "drumstickcow", "prosciuttotongue", "frankfurterchicken", "porkchuck", "capicolabacon",
                            "leberkastail", "ribsham", "sausageshort", "brisketmeatball", "meatballspare", "loinsirloin",
                            "flankdrumstick", "jowlsausage", "hockshort", "donerjerky", "porksausage", "leberkaspork",
                            "tailchicken", "hamburgerpastrami", "donerleberkas", "bellypancetta", "turkeysirloin",
                            "mignonrump", "leberkasandouille", "salamipig", "mignondoner", "beefshankle", "beeftail",
                            "tenderloinsalami", "cowspare", "jerkybresaola", "t-bonepork", "kielbasaribeye",
                            "sirloinvenison", "jerkyshank", "turduckenprosciutto", "hockfatback", "loinboudin",
                            "sirloinbrisket", "tippastrami", "shankledoner", "ribspastrami", "mignonkielbasa",
                            "biltongflank", "steakribeye", "chucktenderloin", "shoulderleberkas", "jerkypig", "beefball",
                            "loinbacon", "bellyjerky", "sausagecorned", "leberkashamburger", "leberkasturducken",
                            "chickenturducken", "chopdoner", "salamidrumstick", "swineleberkas", "donerjowl",
                            "jowlvenison", "bellypig", "donerandouille", "baconandouille", "shouldert-bone", "chopbeef"
                        }
                }
            },
        };

        public static Dictionary<string, string[]> Pessoa = new Dictionary<string, string[]>
        {
            {
                "Homen",
                new[]
                {
                    "rafael", "bruno", "andré", "luiz", "tiago", "felipe", "guilherme", "daniel", "lucas", "rodrigo",
                    "fernando", "joão", "pedro", "fábio", "marcelo", "victor", "eduardo", "gustavo", "gabriel", "paulo",
                    "ricardo", "josé", "carlos", "leonardo", "alexandre", "leandro", "vinícius", "renato", "marcos",
                    "caio", "mateus", "diego", "henrique", "danilo", "arthur", "renan", "maurício", "antônio", "márcio",
                    "flávio", "william", "marco", "anderson", "roberto", "julio", "francisco", "diogo", "douglas",
                    "sérgio", "césar", "murilo", "igor", "adriano", "alan", "eric", "alex", "filipe", "ivan", "mário",
                    "hugo", "marcel", "rodolfo", "rogério", "marcus", "luciano", "jorge", "edson", "fabrício", "claudio",
                    "denis", "augusto", "david", "frederico", "samuel", "yuri", "otávio", "juliano", "davi", "wagner",
                    "michel", "jefferson", "celso", "ronaldo", "robson", "mauro", "fabiano", "alberto", "heitor",
                    "rubens", "thomas", "alessandro", "emerson", "cristiano", "everton", "jonas", "breno", "cássio",
                    "wellington", "thales", "evandro"
                }
            },
            {
                "AgNomes", new[] {"junior", "neto", "filho"}
            },
            {
                "Mulher",
                new[]
                {
                    "adriana", "alessandra", "alice", "aline", "alinne", "amanda", "ana", "anna", "andrea", "andreia",
                    "andressa", "ariane", "beariz", "bianca", "bruna", "bárbara", "camila", "carla", "carolina",
                    "caroline", "cecília", "cláudia", "cristiane", "cristina", "cíntia", "daniela", "danielle", "denise",
                    "débora", "elaine", "eliane", "elisa", "emanuele", "emanuelle", "fabiana", "fernada", "flávia",
                    "gabriela", "giovanna", "gisele", "helena", "heloisa", "isabel", "isabela", "isadora", "janaina",
                    "jaqueline", "joyce", "julia", "juliana", "jéssica", "karen", "karina", "kelly", "kátia", "lara",
                    "larissa", "laura", "laís", "letícia", "lgia", "lilian", "luana", "luciana", "luiza", "lívia",
                    "marcela", "maria", "mariana", "mariane", "marina", "marília", "mayara", "mayra", "michelle",
                    "milena", "márcia", "mônica", "natália", "nádia", "pamela", "patrícia", "paula", "priscila",
                    "rafaela", "raquel", "renata", "roberta", "sabrina", "sandra", "sarah", "silvia", "simone",
                    "stephanie", "talita", "tatiana", "tatiane", "thaís", "vanessa", "verônica", "vitória", "vivian",
                    "viviane"
                }
            },
            {
                "Sobrenomes",
                new[]
                {
                    "aguiar", "aires", "alencar", "almeida", "alves", "amorim", "antunes", "araújo", "azevedo",
                    "barbosa",
                    "barreto", "barros", "borges", "brito", "cabral", "campelo", "cardoso", "carvalho", "castro",
                    "cavalcante", "correia", "costela", "cunha", "dias", "dutra", "escobar", "farias", "faustino",
                    "fernandes", "ferreira", "flores", "garcia", "gomes", "guimarães", "gusmão", "leite", "leitão",
                    "lima", "lopes", "macedo", "machado", "magalhães", "martins", "melo", "mendonça", "moreira",
                    "nascimento", "nogueira", "nunes", "oliveira", "paes", "paiva", "pereira", "pinto", "queiroz",
                    "ramos", "ribeiro", "rocha", "rodrigues", "santos", "saraiva", "silva", "soares", "souza", "xavier"
                }
            }
        };
    }
}