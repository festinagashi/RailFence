using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Server_TCP
{
    class Jwt
    {
        Shfrytezuesi m = new Shfrytezuesi();
        private static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        private static RSAParameters privateKey = rsa.ExportParameters(true);

        public String createToken(String userId, String muaji, String emriMbiemri, Decimal vleraNeEuro, String llojiFatures)
        {
            var payload = new Dictionary<string, object>
        {
            { "userId", userId },
            { "muaji",muaji },
            {"emriMbiemri", emriMbiemri },
            {"vleraNeEuro", vleraNeEuro },
            {"llojiFatures", llojiFatures },
        };
            const string secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);
            var token = encoder.Encode(payload, privateKey.ToString());
            return token;
        }
        
    }
}
