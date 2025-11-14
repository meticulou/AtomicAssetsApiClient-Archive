using AtomicAssetsApiClient.Accounts;
using AtomicAssetsApiClient.Assets;
using AtomicAssetsApiClient.Burns;
using AtomicAssetsApiClient.Collections;
using AtomicAssetsApiClient.Config;
using AtomicAssetsApiClient.Offers;
using AtomicAssetsApiClient.Schemas;
using AtomicAssetsApiClient.Templates;
using AtomicAssetsApiClient.Transfers;

namespace AtomicAssetsApiClient
{
    public class AtomicAssetsApiFactory
    {
        private readonly string _baseUrl;
        private const string AtomicAssetsIO = "https://wax.api.atomicassets.io/atomicassets/v1";
        private const string EOSAmsterdam = "https://wax-aa.eu.eosamsterdam.net/atomicassets/v1";
        private const string EOSAuthority = "https://aa-api-wax.eosauthority.com/atomicassets/v1";
        private const string testnet3DK = "https://testatomic.3dkrender.com/atomicassets/v1";
        private const string testnetNefty = "https://aa-testnet-public.neftyblocks.com/atomicassets/v1";

        private AtomicAssetsApiFactory(string baseUrl) => _baseUrl = baseUrl;

        public static AtomicAssetsApiFactory MainNet1 => new AtomicAssetsApiFactory(AtomicAssetsIO);
        public static AtomicAssetsApiFactory MainNet2 => new AtomicAssetsApiFactory(EOSAmsterdam);
        public static AtomicAssetsApiFactory MainNet3 => new AtomicAssetsApiFactory(EOSAuthority);
        public static AtomicAssetsApiFactory TestNet1 => new AtomicAssetsApiFactory(testnet3DK);
        public static AtomicAssetsApiFactory TestNet2 => new AtomicAssetsApiFactory(testnetNefty);

        public AccountsApi AccountsApi => new AccountsApi(_baseUrl, new HttpHandler());

        public AssetsApi AssetsApi => new AssetsApi(_baseUrl, new HttpHandler());

        public BurnsApi BurnsApi => new BurnsApi(_baseUrl, new HttpHandler());

        public CollectionsApi CollectionsApi => new CollectionsApi(_baseUrl, new HttpHandler());

        public ConfigApi ConfigApi => new ConfigApi(_baseUrl, new HttpHandler());

        public OffersApi OffersApi => new OffersApi(_baseUrl, new HttpHandler());

        public SchemasApi SchemasApi => new SchemasApi(_baseUrl, new HttpHandler());

        public TemplatesApi TemplatesApi => new TemplatesApi(_baseUrl, new HttpHandler());

        public TransfersApi TransfersApi => new TransfersApi(_baseUrl, new HttpHandler());
    }
}
