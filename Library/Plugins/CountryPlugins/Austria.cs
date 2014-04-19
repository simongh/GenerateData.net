using System.Collections.Generic;

namespace GenerateData.Plugins.CountryPlugins
{
	public class Austria : CountryPlugin
	{
		//	protected $extendedData = array(
		//	"zipFormat" => "Xxxx"
		//);
		public override void Install(ICountryPluginService service)
		{
			service.PopulateDb(GetData());
		}

		private Data.Country GetData()
		{
			var c = new Data.Country
			{
				Name = "Austria",
				Regions = new List<Data.Region>
				{ 
					new Data.Region
					{
						Name = "Vienna",
						ShortName = "Wien",
						Weight = 4113,
						Cities = new List<Data.City>
						{
							new Data.City { Name ="Vienna"}
						}
					},
					new Data.Region
					{
						Name = "Vorarlberg",
						ShortName = "Vbg.",
						Weight = 142,
						Cities = new List<Data.City>
						{
							new Data.City { Name = "Dornbirn"},
							new Data.City { Name = "Feldkirch"},
							new Data.City { Name = "Bregenz"},
							new Data.City { Name = "Lustenau"},
							new Data.City { Name = "Hohenems"},
							new Data.City { Name =  "Bludenz"},
							new Data.City { Name = "Hard"},
							new Data.City { Name = "Rankweil"},
							new Data.City { Name = "Götzis"},
							new Data.City { Name = "Lauterach"},
							new Data.City { Name = "Wolfurt"},
							new Data.City { Name = "Höchst"},
							new Data.City { Name = "Altach"}
						}
					},
					new Data.Region
					{
						Name ="Upper Austria",
						ShortName = "OÖ.",
						Weight = 117,
						Cities = new List<Data.City>{
							new Data.City { Name ="Linz"},
							new Data.City { Name = "Wels"},
							new Data.City { Name = "Steyr"},
							new Data.City { Name = "Leonding"},
							new Data.City { Name = "Traun"},
							new Data.City { Name = "Braunau am Inn"},
							new Data.City { Name = "Ansfelden"},
							new Data.City { Name = "Bad Ischl"},
							new Data.City { Name = "Gmunden"},
							new Data.City { Name = "Marchtrenk"},
							new Data.City { Name = "Vöcklabruck"},
							new Data.City { Name = "Ried im Innkreis"},
							new Data.City { Name = "Enns"},
							new Data.City { Name = "Altmünster"},
							new Data.City { Name = "Laakirchen"},
							new Data.City { Name = "Sierning"}
						}
					},
					new Data.Region
					{
						Name = "Lower Austria",
						ShortName = "NÖ.",
						Weight = 84,
						Cities = new List<Data.City>{
							new Data.City { Name ="St. Pölten"},
							new Data.City { Name = "Wiener Neustadt"},
							new Data.City { Name = "Klosterneuburg"},
							new Data.City { Name = "Baden"},
							new Data.City { Name = "Krems an der Donau"},
							new Data.City { Name = "Amstetten"},
							new Data.City { Name = "Mödling"},
							new Data.City { Name = "Traiskirchen"},
							new Data.City { Name = "Schwechat"},
							new Data.City { Name = "Stockerau"},
							new Data.City { Name = "Tulln an der Donau"},
							new Data.City { Name = "Ternitz"},
							new Data.City { Name = "Perchtoldsdorf"},
							new Data.City { Name = "Korneuburg"},
							new Data.City { Name = "Neunkirchen"},
							new Data.City { Name = "Hollabrunn"},
							new Data.City { Name = "Waidhofen an der Ybbs"},
							new Data.City { Name = "Bad Vöslau"},
							new Data.City { Name = "Brunn am Gebirge"},
							new Data.City { Name = "Zwettl-Niederösterreich"}
						}
					},
					new Data.Region
					{
						Name = "Salzburg",
						ShortName = "Sbg.",
						Weight = 74,
						Cities = new List<Data.City>{
							new Data.City { Name ="Salzburg"},
							new Data.City { Name = "Hallein"},
							new Data.City { Name = "Saalfelden am Steinernen Meer"},
							new Data.City { Name = "Wals-Siezenheim"},
							new Data.City { Name = "Sankt Johann im Pongau"},
							new Data.City { Name = "Bischofshofen"}
						}
					},
					new Data.Region
					{
						Name = "Styria",
						ShortName = "Stm.",
						Weight = 73,
						Cities = new List<Data.City>{
							new Data.City { Name ="Graz"},
							new Data.City { Name = "Leoben"},
							new Data.City { Name = "Kapfenberg"},
							new Data.City { Name = "Bruck an der Mur"},
							new Data.City { Name =  "Knittelfeld"},
							new Data.City { Name = "Köflach"},
							new Data.City { Name = "Voitsberg"},
							new Data.City { Name = "Judenburg"},
							new Data.City { Name = "Weiz"}
						}
					},
					new Data.Region
					{
						Name = "Burgenland",
						ShortName = "Bgl.",
						Weight = 72,
						Cities = new List<Data.City>{
							new Data.City { Name ="Eisenstadt"},
							new Data.City { Name = "Oberwart"},
							new Data.City { Name = "Neusiedl am See"},
							new Data.City { Name = "Mattersburg"},
							new Data.City { Name = "Pinkafeld"},
							new Data.City { Name = "Neudörfl"},
							new Data.City { Name = "Parndorf"},
							new Data.City { Name = "Jennersdorf"},
							new Data.City { Name = "Güssing"},
							new Data.City { Name = "Gols"},
							new Data.City { Name = "Großpetersdorf"},
							new Data.City { Name = "Neufeld an der Leitha"},
							new Data.City { Name = "Deutschkreutz"},
							new Data.City { Name = "Rechnitz"},
							new Data.City { Name = "Oberpullendorf"},
							new Data.City { Name = "Siegendorf"},
							new Data.City { Name = "Pöttsching"},
							new Data.City { Name = "Bruckneudorf"},
							new Data.City { Name =  "Frauenkirchen"},
							new Data.City { Name = "Forchtenstein"}
						}
					},
					new Data.Region
					{
						Name = "Carinthia",
						ShortName = "Ktn.",
						Weight = 59,
						Cities = new List<Data.City>{
							new Data.City { Name ="Klagenfurt"},
							new Data.City { Name = "Villach"},
							new Data.City { Name = "Wolfsberg"},
							new Data.City { Name = "Spittal an der Drau"},
							new Data.City { Name = "Feldkirchen in Kärnten"},
							new Data.City { Name = "St. Veit an der Glan"},
							new Data.City { Name = "Völkermarkt"},
							new Data.City { Name = "St. Andrä"},
							new Data.City { Name = "Velden am Wörther See"},
							new Data.City { Name = "Finkenstein am Faaker See"},
							new Data.City { Name = "Ebenthal in Kärnten"},
							new Data.City { Name = "Ferlach"}
						}
					},
					new Data.Region
					{
						Name = "Tyrol",
						ShortName = "Tirol",
						Weight = 56,
						Cities = new List<Data.City>{
							new Data.City { Name = "Innsbruck"},
							new Data.City { Name =  "Kufstein"},
							new Data.City { Name = "Telfs"},
							new Data.City { Name = "Schwaz"},
							new Data.City { Name = "Hall in Tirol"},
							new Data.City { Name = "Wörgl"},
							new Data.City { Name = "Lienz"},
							new Data.City { Name = "Imst"},
							new Data.City { Name = "Rum"},
							new Data.City { Name = "St. Johann in Tirol"},
							new Data.City { Name = "Kitzbühel"},
							new Data.City { Name = "Zirl"},
							new Data.City { Name = "Landeck"}
						}
					}
				}
			};

			return c;
		}
	}
}
