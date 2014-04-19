using System.Collections.Generic;

namespace GenerateData.Plugins.CountryPlugins
{
	public class Australia : CountryPlugin
	{
		//		protected $extendedData = array(
		//	"zipFormat" => array(
		//		"format" => "Xxxx",
		//		"replacements" => array(
		//			"X" => "123456789",
		//			"x" => "0123456789"
		//		)
		//	),
		//	"phoneFormat" => array(
		//		"displayFormats" => array(
		//			"xxxx-xxxx",
		//			"(0x) xxxx xxxx",
		//			"04xx xxx xxx"
		//		)
		//	)
		//);

		public override void Install(ICountryPluginService service)
		{
			service.PopulateDb(GetData());
		}

		private Data.Country GetData()
		{
			var c = new Data.Country
			{
				Name = "Australia",
				Regions = new List<Data.Region>{
					new Data.Region{
						Name = "Australian Capital Territories",
						ShortName = "AC",
						Weight = 3,
						Cities = new List<Data.City>{
							new Data.City{Name = "Canberra"}
						}
					},
					new Data.Region{
						Name= "New South Wales",
						ShortName= "NS",
						Weight= 69,
						Cities=new List<Data.City>{
							new Data.City{ Name = "Sydney"},
							new Data.City{ Name = "Albury"},
							new Data.City{ Name = "Armidale"},
							new Data.City{ Name = "Bathurst"},
							new Data.City{ Name = "Blue Mountains"},
							new Data.City{ Name = "Broken Hill"},
							new Data.City{ Name = "Campbelltown"},
							new Data.City{ Name = "Cessnock"},
							new Data.City{ Name = "Dubbo"},
							new Data.City{ Name = "Goulburn"},
							new Data.City{ Name = "Grafton"},
							new Data.City{ Name = "Lithgow",},
							new Data.City{ Name = "Liverpool"},
							new Data.City{ Name = "Newcastle"},
							new Data.City{ Name = "Orange"},
							new Data.City{ Name = "Parramatta"},
							new Data.City{ Name = "Penrith"},
							new Data.City{ Name = "Queanbeyan"},
							new Data.City{ Name = "Tamworth"},
							new Data.City{ Name = "Wagga Wagga"},
							new Data.City{ Name = "Wollongong"}
						}
					},
					new Data.Region{
						Name = "Northern Territory",
						ShortName = "NT",
						Weight = 2,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Darwin"},
							new Data.City{ Name = "Palmerston"}
						}
					},
					new Data.Region{
						Name = "Queensland",
						ShortName = "QL",
						Weight = 42,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Brisbane"},
							new Data.City{ Name = "Bundaberg"},
							new Data.City{ Name = "Cairns"},
							new Data.City{ Name = "Caloundra"},
							new Data.City{ Name = "Charters Towers"},
							new Data.City{ Name = "Gladstone"},
							new Data.City{ Name = "Gold Coast"},
							new Data.City{ Name = "Hervey Bay"},
							new Data.City{ Name = "Ipswich"},
							new Data.City{ Name = "Logan City"},
							new Data.City{ Name = "Mackay"},
							new Data.City{ Name = "Maryborough"},
							new Data.City{ Name = "Mount Isa"},
							new Data.City{ Name = "Redcliffe"},
							new Data.City{ Name = "Redlands"},
							new Data.City{ Name = "Rockhampton"},
							new Data.City{ Name = "Toowoomba"},
							new Data.City{ Name = "Townsville"}
						}
					},
					new Data.Region{
						Name = "South Australia",
						ShortName = "SA",
						Weight = 16,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Adelaide"},
							new Data.City{ Name = "Mount Gambier"},
							new Data.City{ Name = "Murray Bridge"},
							new Data.City{ Name = "Port Augusta"},
							new Data.City{ Name = "Port Pirie"},
							new Data.City{ Name = "Port Lincoln"},
							new Data.City{ Name = "Victor Harbor"},
							new Data.City{ Name = "Whyalla"}
						}
					},
					new Data.Region{
						Name = "Tasmania",
						ShortName = "TA",
						Weight = 5,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Greater Hobart"},
							new Data.City{ Name = "Burnie"},
							new Data.City{ Name = "Devonport"},
							new Data.City{ Name = "Launceston"}
						}
					},
					new Data.Region{
						Name = "Victoria",
						ShortName = "VI",
						Weight = 52,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Melbourne"},
							new Data.City{ Name = "Ararat"},
							new Data.City{ Name = "Bairnsdale"},
							new Data.City{ Name = "Benalla"},
							new Data.City{ Name = "Ballarat"},
							new Data.City{ Name = "Bendigo"},
							new Data.City{ Name = "Belgrave"},
							new Data.City{ Name = "Dandenong"},
							new Data.City{ Name = "Frankston"},
							new Data.City{ Name = "Geelong"},
							new Data.City{ Name = "Hamilton"},
							new Data.City{ Name = "Horsham"},
							new Data.City{ Name = "Melton"},
							new Data.City{ Name = "Moe"},
							new Data.City{ Name = "Morwell"},
							new Data.City{ Name = "Mildura"},
							new Data.City{ Name = "Sale"},
							new Data.City{ Name = "Shepparton"},
							new Data.City{ Name = "Swan Hill"},
							new Data.City{ Name = "Traralgon"},
							new Data.City{ Name = "Wangaratta"},
							new Data.City{ Name = "Warrnambool"},
							new Data.City{ Name = "Wodonga"}
						}
					},
					new Data.Region{
						Name = "Western Australia",
						ShortName = "WA",
						Weight = 21,
						Cities = new List<Data.City>{
							new Data.City{ Name = "Perth"},
							new Data.City{ Name = "Albany"},
							new Data.City{ Name = "Armadale"},
							new Data.City{ Name = "Bayswater"},
							new Data.City{ Name = "Belmont"},
							new Data.City{ Name = "Bunbury"},
							new Data.City{ Name = "Canning"},
							new Data.City{ Name = "Cockburn"},
							new Data.City{ Name = "Fremantle"},
							new Data.City{ Name = "Geraldton-Greenough"},
							new Data.City{ Name = "Gosnells"},
							new Data.City{ Name =  "Joondalup"},
							new Data.City{ Name = "Kalgoorlie-Boulder"},
							new Data.City{ Name = "Mandurah"},
							new Data.City{ Name = "Melville"},
							new Data.City{ Name = "Nedlands"},
							new Data.City{ Name = "Rockingham"},
							new Data.City{ Name = "South Perth"},
							new Data.City{ Name = "Stirling"},
							new Data.City{ Name = "Subiaco"},
							new Data.City{ Name = "Swan"},
							new Data.City{ Name = "Wanneroo"}
						}
					}
				}
			};

			return c;
		}
	}
}
