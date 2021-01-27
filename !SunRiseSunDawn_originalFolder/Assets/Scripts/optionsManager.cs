using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class optionsManager : MonoBehaviour {

	//FUNKCJE PUBLICZNE

	//FUNKCJE LOKALNE

	//FUNKCJE POZOSTALE

	public string lang;
	public int sound;
	int[] levelsUnlocks = new int[36];
	public int numerAforyzmuMenu;

	public Text numerCytatuText;
	public Text trescCytatuText;
	//public GameObject crossedNoteHandler;
	public GameObject levelManager;
	public GameObject[] soundSources;
	public Text SoundText;
	Dictionary<string,string> dictPL;
	Dictionary<string,string> dictEN;
	public Text[] listaObiektowDoTlumaczenia;
	public bool isMenu;


/*	string[] aforyzmyPL={
		"Sukces jest największą, dostępną, ludzką zemstą. - Norman Vincent Peale",
		"W życiu nie ma rzeczy, których można żałować. Są tylko rzeczy, na których można się uczyć. - Jennifer Aniston",
		"Dwa najważniejsze dni Twojego życia to ten, w którym się urodziłeś oraz ten, w którym dowiedziałeś się po co. - Mark Twain",
		"Co należy zrobić po upadku? To co robią dzieci: podnieść się. -  Aldous Huxley",
		"Choć nikt nie może cofnąć się w czasie i zmienić początku na zupełnie inny, to każdy może zacząć dziś i stworzyć całkiem nowe zakończenie. - Carl Bard",
		"Początek jest najważniejszą częścią pracy. - Platon",
		"Zwycięzcy robią to, czego przegranym się nie chciało. - Jonathan Carroll",
		"Nie oczekujcie od dnia tego, co mogą dać jedynie lata. Ale nie zapominajcie, że lata składają się z wielu dni, dlatego postanówcie, że nie zmarnujecie ani jednego. - J. M. Sailer",
		"Porażka jest po prostu okazją, by spróbować ponownie, tym razem bardziej przemyślanie. - Henry Ford",
		"To, czego boimy się najbardziej, jest z reguły tym, co właśnie powinniśmy zrobić. - Ralph W. Emerson",
		"Nic nie jest szczególnie trudne do zrobienia, jeśli tylko rozłożyć to na etapy. - Henry Ford",
		"Za dwadzieścia lat bardziej będziesz żałował tego, czego nie zrobiłeś, niż tego, co zrobiłeś. Więc odwiąż liny, opuść bezpieczną przystań. Złap w żagle pomyślne wiatry. Podróżuj, śnij, odkrywaj. - Mark Twain",
		"Zacznij tam gdzie jesteś, użyj tego co masz, zrób co możesz. - Arthur Ashe",
		"Statki w porcie są bezpieczne, ale stanie w porcie nie jest ich przeznaczeniem. - John Shedd",
		"W życiu wiele ludzi wie, co robić, ale mało ludzi robi to, co wie… Nie wystarczy tylko wiedzieć! Musisz podjąć działanie. - Anthony Robbins",
		"Gdybyśmy czekali na ten jeden moment, kiedy wszystko, absolutnie wszystko jest gotowe, nigdy byśmy nic nie zaczęli. - Iwan Turgieniew",
		"Być może nic nie jest warte zachodu, aby to lub tamto czynić. Ale wszystko, co czynimy, jest w każdym razie warte, aby to czynić doskonale. - Johann Wolfgang von Goethe",
		"Potykając się, można zajść daleko. Nie wolno tylko upaść i nie podnieść się. - Johann Wolfgang von Goethe",
		"Przyszłość zaczyna się dzisiaj, nie jutro. - Jan Paweł II",
		"Życie stawia przed Tobą wymagania na miarę sił, które posiadasz. Możliwy jest tylko jeden bohaterski czyn: nie uciec. - Dag Hammarskjöld",
		"Dalej. Otwórz drzwi, o których mówiono, że nie da się ich otworzyć. Tam czeka życie. - Kelly Ann Rothaus",
		"Najpotężniejszą siłą we wszechświecie jest siła woli. - Andrzej Majewski",
		"Ludzie, którzy nie wierzą w sukces, nie wygrywają. - Włodzimierz Szaranowicz",
		"Cel jest to marzenie z datą wykonania. - Napoleon Hill",
		"Cokolwiek potrafisz lub myślisz, że potrafisz, rozpocznij to. Odwaga ma w sobie geniusz, potęgę i magię. - Johann Wolfgang von Goethe",
		"Jesteś projektantem swojego przeznaczenia. Jesteś jego autorem. Sam piszesz historię. Pióro tkwi w Twoim ręku, a wynik zależy od tego, co wybierzesz. - Lisa Nichols",
		"Wyobraźnia jest początkiem tworzenia. Wyobrażasz sobie to, czego pragniesz, chcesz tego, co sobie wyobraziłeś, i w końcu tworzysz to, czego chcesz. - George Bernard Shaw",
		"Motywacja jest tym, co pozwala Ci zacząć. Nawyk jest tym, co pozwala Ci wytrwać. - Jim Ryun",
		"Najlepszy czas na działanie jest teraz! - Mark Fisher",
		"Prawdziwa decyzja jest mierzona poprzez fakt podjęcia nowego działania. Jeśli nie ma działania – tak naprawdę nie podjąłeś decyzji. - Tony Robbins",
		"W konfrontacji strumienia ze skałą, strumień zawsze wygrywa - nie przez swoją siłę, ale przez wytrwałość. - Budda",
		"Mędrcami są ci, który dochodzą do prawdy przez błędy. Ci, którzy upierają się przy błędach, są głupcami. - Friedrich Ruckert",
		"Dopóki nie uczynisz nieświadomego świadomym, będzie ono kierowało Twoim życiem, a Ty będziesz nazywał to przeznaczeniem. - Carl Gustav Jung",
		"Mówisz, że możesz – to możesz. Mówisz, że nie możesz – to nie możesz. Więc sobie wybierz. - Mistrz Zen Seung Sahn",
		"Pamiętaj, że mamy do czynienia jedynie z myślami, a myśli mogą zostać zmienione. Gdy zmieniamy nasze myślenie, zmieniamy naszą rzeczywistość. - Louise L. Hay",
		"Jesteś jedyną osobą na świecie, która może wykorzystać Twój potencjał. - Zig Ziglar",

		"Najlepsi nauczyciele to tacy, którzy powiedzą Ci gdzie patrzeć, ale nie powiedzą Ci co widzieć. - Alexandra K. Trenfor",
		"Życie przypomina czyste płótno: możesz wciąż je dźwigać i umrzeć pod jego ciężarem, ale jaki to ma sens? Namaluj coś na nim! -  Osho",
		"Nie ma wielkiej odwagi tam, gdzie nie ma wiary we własne siły i pewności siebie; połowa sukcesu zależy od przekonania, że osiągniemy to, co zamierzyliśmy. - Orison Swett Marden",
		"Pesymista szuka przeciwności w każdej okazji. Optymista widzi okazję w każdej przeciwności. - Winston Churchill",
		"Lepiej jest zapalić świecę, niż przeklinać ciemność. - Matka Teresa z Kalkuty",
		"Mistrzowie grają dotąd, aż grają dobrze. - Billie Jean King",
		"Najtrudniejsze jest zdecydowanie się na działanie. Reszta to już tylko kwestia wytrwałości. - Amelia Earhart",
		"W życiu nie zawsze wygrywają najmądrzejsi, najpiękniejsi i najbardziej przebojowi. Wygrywają ci, którzy postanawiają wygrać. - Kamila Rowińska ",
		"Ludzie najczęściej rezygnują ze swej siły poprzez myślenie, że nie mają żadnej. - Alice Walker",
		"Pudłujesz 100% strzałów, jeśli w ogóle ich nie wykonujesz. – Wayne Gretzky",
		"Aby przebyć tysiąc mil, trzeba zrobić pierwszy krok. – Bruce Lee",
		"Na początku jest to trudne, ale na początku wszystko jest trudne. - Musashi Miyamoto",
		"I zawsze pamiętaj, że jesteś kimś wyjątkowym. Jedyne, co musisz zrobić, to pozwolić innym zobaczyć, że taki jesteś. - Milton Erickson",
		"Nagrodą za rzecz dobrze zrobioną jest to, że jest zrobiona. - T. Edison",
		"Sukces to robienie tego, co się chce robić. Nie ma innej drogi do sukcesu.- M. Forbes",
		"Z radością witaj poważne, trudne i skomplikowane problemy. To w nich kryją się największe możliwości. - R. Marston",
		"Aby do czegoś dojść, trzeba wyruszyć w drogę. - Wiesław Czermak",
		"Błąd jest przywilejem filozofów, tylko głupcy nie mylą się nigdy. - Sokrates",
		"Zajrzyj w siebie! W twoim wnętrzu jest źródło, które nigdy nie wyschnie jeśli potrafisz je odszukać. - Marek Aureliusz",
		"Jeśli nie mogę przejść przez jedne drzwi - przejdę przez inne, albo stworzę nowe. Coś wspaniałego stanie się, bez względu na to, jak ciemna jest chwila obecna. - Joan Rivers",
		"Najpewniejszym sposobem na uniknięcie porażki jest determinacja, by osiągnąć sukces. - Richard B. Sheridan",
		"Wszyscy wiedzą, że czegoś nie da się zrobić, i przychodzi taki jeden, który nie wie, że się nie da, i on to właśnie robi. - Albert Einstein",
		"Znajdź pracę, którą lubisz, a do końca życia nie będziesz musiał pracować. - Konfucjusz",
		"Dopóki walczysz - jesteś zwycięzcą. - Augustyn z Hippony",
		"Wytrwałości, aby zmienić to, co zmienić można. Pogody ducha, aby pogodzić się z tym czego zmienić nie można. I mądrości aby odróżnić jedno od drugiego. - Marek Aureliusz",
		"Nasza największa słabość tkwi w rezygnowaniu. Najbardziej pewną rzeczą, aby odnieść sukces jest spróbować jeszcze raz. - Thomas A. Edison",
		"Nie odniosłem porażki. Po prostu odkryłem 10.000 błędnych rozwiązań. - Thomas A. Edison",
		"Albo odnajdziemy drogę, albo ją zbudujemy. - Hannibal",
		"Każdy ma dość siły, aby urzeczywistnić to, o czym jest przekonany. - Johann Wolfgang Goethe",
		"Przyjdzie taka chwila, gdy stwierdzisz, że wszystko się skończyło. To właśnie będzie początek.  – Luis Dearborn L’Amour",
		"Niech strach przed niepowodzeniem nie powstrzyma cię przed wejściem do gry. -Jerzy Walczak",
		"Tam gdzie nie ma walki nie ma siły. – Oprah Winfrey",
		"Rób co możesz, tym co posiadasz i tam gdzie jesteś. – Theodore Roosevelt",
		"Żadne zadanie nie jest szczególnie trudne, jeśli podzielisz je na mniejsze podzadania. - Henry Ford",
		"Mądry człowiek nie opłakuje przegranej, lecz szuka sposobu, jak wyleczyć odniesione rany. – William Szekspir",
		"Nigdy, nigdy, nigdy, nigdy się nie poddawaj. - Winston Churchill",
		"Patrząc zawsze przed siebie, myśląc o tym, jak zrobić jeszcze więcej, osiągniesz stan umysłu, w którym nie ma rzeczy niemożliwych. - Henry Ford",
		"Kreatywność to pozwolenie sobie na popełnianie błędów, sztuką zaś to wiedzieć, przy których błędach warto pozostać. - Scott Adams",
		"Cierpliwość i wytrwałość mają magiczne działanie – dzięki nim trudności znikają, a przeszkody ulatniają się. - John Quincy Adams",
		"Jakże szybko \"nie teraz\" staje się \"nigdy\". - Martin Luther King",
		"Zacznij od robienia tego, co konieczne. Potem zrób to, co możliwe. Nagle odkryjesz, że dokonałeś niemożliwego. -  św. Franciszek z Asyżu",
		"Dysponując zwykłymi talentami i niezwykłą wytrwałością możesz osiągnąć wszystko. - Thomas Fowell Buxton",
		"By być wielkim mistrzem, musisz wierzyć, że jesteś najlepszy. Jeżeli to nieprawda – udawaj, że jednak jesteś. - Muhammad Ali",
		"Jeśli możesz coś zrobić lub marzysz, że mógłbyś to zrobić, zabierz się za to. Odwaga ma w sobie moc geniuszu. - Johann Wolfgang von Goethe",
		"Wszystko, co doskonałe dojrzewa powoli. -  Arthur Schopenhauer",
		"Odkryłem, że im ciężej pracuję tym bardziej sprzyja mi szczęście. - Thomas Jefferson",
		"Wyobraźnia jest ważniejsza od wiedzy, ponieważ wiedza jest ograniczona. - Albert Einstein",
		"Ciężki trening, łatwa walka. Łatwy trening, ciężka walka - Aleksandr Suworow",
		"Wiedza zapewni ci potęgę, a charakter uznanie. - Bruce Lee",
		"Jedyną drogą rozwoju jest ciągłe podnoszenie poprzeczki, jedyną miarą sukcesu jest wysiłek jaki włożyliśmy, aby go osiągnąć. - Bruce Lee",
		"Jeśli będziesz starał się ze wszystkich sił, to nie będziesz miał czasu na lęk przed porażką. -  H. Jackson Brown",
		"Wiedza jest drugim słońcem dla ludzi. – Platon",
		"Bardzo wiele książek należy przeczytać po to, aby sobie uświadomić, jak mało się wie. – Mikołaj Gogol",
		"Prawdziwa wiedza to znajomość przyczyn. – Arystoteles",
		"Wyobraźnia bez wiedzy może stworzyć rzeczy piękne. Wiedza bez wyobraźni najwyżej doskonałe. – Albert Einstein",
		"Bądź dobrej myśli, bo po co być złej. – Stanisław Lem",
		"Nigdy nie chodzi o to, jak wielki jest problem, liczy się tylko, jak wielki jesteś Ty. - T. Harv Eker",
		"Jeśli ktoś chce dotrzeć do określonego miejsca niech wybierze jedną drogę i nie zastanawia się nad innymi, ponieważ nie byłaby to już podroż lecz włóczęga. – Seneka Młodszy",
		"Kto chce wejść na szczyt, musi zaczynać od dołu, a potem iść krok za krokiem, nie przyspieszając go. Zły to taternik czy alpinista, który zaczyna wspinaczkę w góry od zrywu i wielkiego wysiłku. Dobry - idzie krok za krokiem, powoli, spokojnie. – Stefan Wyszyński",
		"Najpierw cię ignorują. Potem śmieją się z ciebie. Później z tobą walczą. Później wygrywasz. - Mahatma Gandhi",
		"Ci, co wygrywają – nigdy nie odpuszczają.  Ci, co odpuszczają – nigdy nie wygrywają… - Vince Lombardi",
	"Być zwyciężonym i nie ulec to zwycięstwo. Zwyciężyć i osiąść na laurach to klęska. -  Józef Piłsudski",
		"Słońce zawsze świeci dla Ciebie, nawet wtedy, kiedy patrząc w niebo widzisz tylko chmury - Damian Żukiewicz",
		"Zawsze wydaje się, że coś jest niemożliwe, dopóki nie zostanie to zrobione. -  Nelson Mandela",
		"Jeżeli myślisz, że jesteś zbyt mały, by coś zmienić, spróbuj zasnąć z komarem latającym nad uchem. -  Dalajlama XIV",
		"Zwycięstwo jest dedykowane dla tych, którzy są gotowi zapłacić jego cenę – Sun Tzu",
		"Radość pochodzi z walki i z samej próby osiągnięcia czegoś, nie ze zwycięstwa samego w sobie. – Mahatma Gandhi",
		"Jeśli nie umiesz latać, biegnij. Jeśli nie umiesz biegać, chodź. Jeśli nie umiesz chodzić, czołgaj się. Ale bez względu na wszystko – posuwaj się naprzód. - Martin Luther King",
		"Jesteśmy tym, co w swoim życiu powtarzamy. Doskonałość nie jest jednorazowym aktem, lecz nawykiem. -  Arystoteles",
		"Mądrzy ciągle się uczą, głupcy najczęściej wszystko umieją. - Apolinary Despinoix",
		"Bez względu na to ile popełnisz błędów, albo jak wolno idą postępy, i tak jesteś przed tymi, którzy nie próbują wcale!  - Tom Robbins"

	};
	string[] aforyzmyEN={
		"The best preparation for tomorrow is doing your best today. - H. Jackson Brown, Jr.",
		"I can't change the direction of the wind, but I can adjust my sails to always reach my destination. - Jimmy Dean",
		"Put your heart, mind, and soul into even your smallest acts. This is the secret of success. - Swami Sivananda",
		"Start by doing what's necessary; then do what's possible; and suddenly you are doing the impossible. - Francis of Assisi",
		"From a small seed a mighty trunk may grow. - Aeschylus",
		"If opportunity doesn't knock, build a door. - Milton Berle",
		"We know what we are, but know not what we may be. - William Shakespeare",
		"All you need is the plan, the road map, and the courage to press on to your destination. - Earl Nightingale",
		"Your present circumstances don't determine where you can go; they merely determine where you start. - Nido Qubein",
	"To be defeated and not submit, is victory; to be victorious and rest on one's laurels, is defeat. - Józef Piłsudski",
		"It is never too late to be what you might have been. - George Eliot",
		"First they ignore you, then they laugh at you, then they fight you, then you win. - Mahatma Gandhi",
		"Life is 10% what happens to you and 90% how you react to it. - Charles R. Swindoll",
		"Good, better, best. Never let it rest. 'Til your good is better and your better is best. - St. Jerome",
		"Live as if you were to die tomorrow. Learn as if you were to live forever. - Mahatma Gandhi",
		"Failure will never overtake me if my determination to succeed is strong enough. - Og Mandino",
		"It does not matter how slowly you go as long as you do not stop. - Confucius",
		"In order to succeed, we must first believe that we can. - Nikos Kazantzakis",
		"The secret of getting ahead is getting started. - Mark Twain",
		"It always seems impossible until it's done. - Nelson Mandela",
		"Our greatest weakness lies in giving up. The most certain way to succeed is always to try just one more time. - Thomas A. Edison",
		"Problems are not stop signs, they are guidelines. - Robert H. Schuller",
		"Keep your eyes on the stars, and your feet on the ground. - Theodore Roosevelt",
		"Quality is not an act, it is a habit. - Aristotle",
		"If you're going through hell, keep going. - Winston Churchill",
		"You can't cross the sea merely by standing and staring at the water. - Rabindranath Tagore",
		"If you want to conquer fear, don't sit home and think about it. Go out and get busy. - Dale Carnegie",
		"The way to get started is to quit talking and begin doing. - Walt Disney",
		"By failing to prepare, you are preparing to fail. - Benjamin Franklin",
		"Without hard work, nothing grows but weeds. - Gordon B. Hinckley",
		"Knowing is not enough; we must apply. Willing is not enough; we must do. - Johann Wolfgang von Goethe",
		"Ever tried. Ever failed. No matter. Try Again. Fail again. Fail better. - Samuel Beckett",
		"Either I will find a way, or I will make one. - Philip Sidney",
		"The most effective way to do it, is to do it. - Amelia Earhart",

		"Be miserable. Or motivate yourself. Whatever has to be done, it's always your choice. - Wayne Dyer",
		"We are not permitted to choose the frame of our destiny. But what we put into it is ours. - Dag Hammarskjöld",

		"An eye for an eye only ends up making the whole world blind. - Mahatma Gandhi"
	};

*/


		
	public void TekstAforyzmuMenu(int numerAforyzmu){
		if (numerAforyzmu == 99) {
			if(numerAforyzmuMenu==36){
				numerAforyzmuMenu = 1;
			}else{
				numerAforyzmuMenu++;
			}
		}
		if (numerAforyzmu == -99) {
			if(numerAforyzmuMenu==1){
				numerAforyzmuMenu = 36;
			}else{
				numerAforyzmuMenu--;
			}
		}
		if (numerAforyzmu == 0) {
			numerAforyzmuMenu = 1;
		}

	//	print ("PlayerPrefs.GetInt (\"level\" + numerAforyzmu): "+PlayerPrefs.GetInt ("level" + numerAforyzmu));

		if (PlayerPrefs.GetInt ("quote" + numerAforyzmuMenu) == 0) {
			trescCytatuText.text = "???";
		} else {

			trescCytatuText.text = GetTranslationOf ("Quote" + numerAforyzmuMenu);


	
		}
			numerCytatuText.text = numerAforyzmuMenu.ToString () + "/36";
		
	}//TekstAforyzmuMenu

	public string TekstAforyzmu(){
	//	print ("tekst aforyzmu: "+GetTranslationOf ("Quote"+levelManager.GetComponent<lvlManager> ().GetLevelNumber ()));

		return GetTranslationOf ("Quote"+levelManager.GetComponent<lvlManager> ().GetLevelNumber ());
	}

	public void ResetSave (){
		PlayerPrefs.DeleteAll ();
	}

	void LoadLangs(){

		foreach (Text t in listaObiektowDoTlumaczenia) {
			t.text = GetTranslationOf(t.GetComponent<trans> ().GetKeyword ());
		}//foreach

	/*	lang=PlayerPrefs.GetString("lang");
		switch(lang){
		case "pl":

			break;
		case "en":

			break;
		default:

		break;
		}
		*/

	}

	public void ChangeLang(){
		lang = PlayerPrefs.GetString ("lang");
		if (lang == "pl") {
			PlayerPrefs.SetString ("lang", "en");
			PlayerPrefs.Save ();
		} else {
			if (lang == "en") {
				PlayerPrefs.SetString("lang", "pl");
				PlayerPrefs.Save ();

			} else {
				print ("blad jezyka");	
			}
		}
		LoadLangs ();
	}



	public void ChangeSoundState(){
	//	crossedNoteHandler.SetActive (!crossedNoteHandler.activeInHierarchy);
		print ("sound było: " + PlayerPrefs.GetInt ("sound"));
		PlayerPrefs.SetInt ("sound", Mathf.Abs(PlayerPrefs.GetInt ("sound")-1));
		print ("sound jest: " + PlayerPrefs.GetInt ("sound"));
		PlayerPrefs.Save ();
		SoundOnOff ();
		//todo - rzeczywiscie wlaczac i wylaczac muzyke
	}

	string PrzetworzNieoczywistyTekst(string keyword){

		switch (keyword) {
		case "QuoteMenu":
			//
			return "Quote1";
			break;
		case "QuoteLevel":
			return "QuoteLocked";//"Quote"+levelManager.GetComponent<lvlManager> ().GetLevelNumber ();
			break;
		case "SoundMenu":
			print ("in " + PlayerPrefs.GetInt ("sound"));
			if (PlayerPrefs.GetInt ("sound") == 1) {
					return "SoundOnMenu";
			} else {
				if (PlayerPrefs.GetInt ("sound") == 0) {
					return "SoundOffMenu";
				} else {
					print ("blad");
				}
			}//if
			return null;
			break;
		case "SoundLevel":
			if (PlayerPrefs.GetInt ("sound") == 1) {
				return "SoundOnLevel";
			} else {
				if (PlayerPrefs.GetInt ("sound") == 0) {
					return "SoundOffLevel";
				} else {
					print ("blad");
				}
			}//if
			break;
		default:
			print ("blad");
			break;
		}//switch
		return null;
	}//PrzetworzNieoczywistyTekst

	public string GetTranslationOf(string keyword){
	//	print (keyword);
		if (PlayerPrefs.HasKey ("lang")) {
			lang = PlayerPrefs.GetString ("lang");
		} else {
			lang = "en";
		}

		if(keyword=="QuoteMenu" || keyword=="QuoteLevel" || keyword=="SoundMenu" || keyword=="SoundLevel"){
			keyword=PrzetworzNieoczywistyTekst(keyword);

		}
	//	print (keyword);
		switch (lang) {
		case "pl":
			return dictPL [keyword];
			break;
		case "en": 
			return dictEN [keyword];
			break;
		default:
			print ("blad");
			break;

		}
		return null;
	}

	void SoundOnOff(){
		//GameObject tekst=this.gameObject.transform.GetChild(0);
		sound=PlayerPrefs.GetInt ("sound");
	//	print ("in SoundOnOff, sound: "+sound);
		if (sound == 0) {
			//crossedNoteHandler.SetActive (false);
			if (isMenu) {
				SoundText.GetComponent<trans> ().UpdateKeyword ("SoundOffMenu");
				SoundText.text = GetTranslationOf ("SoundOffMenu");
			} else {
				SoundText.GetComponent<trans> ().UpdateKeyword ("SoundOffLevel");
				SoundText.text = GetTranslationOf ("SoundOffLevel");
			}
			foreach (GameObject g in soundSources) {
		//		print (g+" "+g.name);
		//		print("czy rowne: "+g.name=="optionsManager");
				g.GetComponent<AudioSource> ().volume = 0;
			}
		} else {
			if (sound == 1) {
			//	crossedNoteHandler.SetActive (true);
				if (isMenu) {
					SoundText.GetComponent<trans> ().UpdateKeyword ("SoundOnMenu");
					SoundText.text = GetTranslationOf ("SoundOnMenu");
				} else {
					SoundText.GetComponent<trans> ().UpdateKeyword ("SoundOnLevel");
					SoundText.text = GetTranslationOf ("SoundOnLevel");
				}
				foreach (GameObject g in soundSources) {
					g.GetComponent<AudioSource> ().volume = 1;
				}
			} else {
				print("blad");
			}
		}
	}

	void InitDicts(){

		//Menu

		dictPL ["Start"] = "Start";
		dictEN ["Start"] = "Start";

		dictPL ["Lang"] = "Polski";
		dictEN ["Lang"] = "English";

		dictPL ["SoundOnMenu"] = "Dźwięk: Wł.";
		dictEN ["SoundOnMenu"] = "Sound: On";

		dictPL ["SoundOffMenu"] = "Dźwięk: Wył.";
		dictEN ["SoundOffMenu"] = "Sound: Off";

		dictPL ["Quotes"] = "Cytaty";
		dictEN ["Quotes"] = "Quotes";
		
		dictPL ["Exit"] = "Wyjście";
		dictEN ["Exit"] = "Exit";

		dictPL ["BackToMenuMenu"] = "Wróć do Menu";
		dictEN ["BackToMenuMenu"] = "Back to Menu";

		//Level

		dictPL ["LevelNr"] = "Poziom: "+levelManager.GetComponent<lvlManager> ().GetLevelNumber ();
		dictEN ["LevelNr"] = "Level: "+levelManager.GetComponent<lvlManager> ().GetLevelNumber ();

		dictPL ["Letters"] = "Literki";
		dictEN ["Letters"] = "Letters";


		dictPL ["AdsButton"] = "Zdobądź\nbrakującą\nliterkę";
		dictEN ["AdsButton"] = "Get\na missing\nletter";

		dictPL ["AdsTutorial"] = "Możesz zdobyć brakującą literkę za oglądniecie reklamy.\n (Wymaga połączenia z internetem.)";
		dictEN ["AdsTutorial"] = "You can get a missing letter for watching the commercial.\n (Internet connection required.)";

		dictPL ["AreYouSure"] = "Na pewno chcesz wrócić do Menu? Twoje postępy nie zostaną zapisane.";
		dictEN ["AreYouSure"] = "Are you sure that you want to go back to Menu? Your progress won't be saved.";

		dictPL ["Tutorial"] = "Zbierz wszystkie 23 kostki, żeby przeczytać cytat i odblokować następny poziom.\n\n Dotknij i przeciągnij przycisk ze strzałkami, żeby się poruszać.";
		dictEN ["Tutorial"] = "Collect all 23 cubes to read the quote and unlock the next level.\n\nTouch and drag the button with arrows to move.";
			
		dictPL ["Watch"] = "Oglądnij";
		dictEN ["Watch"] = "Watch";

		dictPL ["NoThanks"] = "Nie, dzięki";
		dictEN ["NoThanks"] = "No, thanks";

		dictPL ["Yes"] = "Tak";
		dictEN ["Yes"] = "Yes";

		dictPL ["No"] = "Nie";
		dictEN ["No"] = "No";


		dictPL ["SoundOnLevel"] = "Dźwięk:\nWł.";
		dictEN ["SoundOnLevel"] = "Sound:\nOn";

		dictPL ["SoundOffLevel"] = "Dźwięk:\nWył.";
		dictEN ["SoundOffLevel"] = "Sound:\nOff";

		dictPL ["BackToMenuLevel"] = "Wróć\ndo\nMenu";
		dictEN ["BackToMenuLevel"] = "Back\nto\nMenu";
			
		//Cytaty
	
		dictPL ["QuoteLocked"] = "???";
		dictEN ["QuoteLocked"] = "???";

		dictPL ["Quote1"] = "Życie stawia przed Tobą wymagania na miarę sił, które posiadasz. Możliwy jest tylko jeden bohaterski czyn: nie uciec.\n\n Dag Hammarskjöld";
		dictEN ["Quote1"] = "Life only demands from you the strength you possess. Only one feat is possible — not to have run away.\n\nDag Hammarskjöld";

		dictPL ["Quote2"] = "W życiu nie ma rzeczy, których można żałować. Są tylko rzeczy, na których można się uczyć.\n\nJennifer Aniston";
		dictEN ["Quote2"] = "The best preparation for tomorrow is doing your best today.\n\nH. Jackson Brown, Jr.";

		dictPL ["Quote3"] = "Dwa najważniejsze dni Twojego życia to ten, w którym się urodziłeś oraz ten, w którym dowiedziałeś się po co.\n\nMark Twain";
		dictEN ["Quote3"] = "The two most important days in your life are the day you were born and the day you find out why.\n\nMark Twain";

		dictPL ["Quote4"] = "Co należy zrobić po upadku? To co robią dzieci: podnieść się.\n\nAldous Huxley";
		dictEN ["Quote4"] = "I can't change the direction of the wind, but I can adjust my sails to always reach my destination.\n\nJimmy Dean";

		dictPL ["Quote5"] = "Choć nikt nie może cofnąć się w czasie i zmienić początku na zupełnie inny, to każdy może zacząć dziś i stworzyć całkiem nowe zakończenie.\n\nCarl Bard";
		dictEN ["Quote5"] = "Put your heart, mind, and soul into even your smallest acts. This is the secret of success.\n\nSwami Sivananda";

		dictPL ["Quote6"] = "Początek jest najważniejszą częścią pracy.\n\nPlaton";
		dictEN ["Quote6"] = "Start by doing what's necessary; then do what's possible; and suddenly you are doing the impossible.\n\nFrancis of Assisi";

		dictPL ["Quote7"] = "Zwycięzcy robią to, czego przegranym się nie chciało.\n\nJonathan Carroll";
		dictEN ["Quote7"] = "From a small seed a mighty trunk may grow.\n\nAeschylus";

		dictPL ["Quote8"] = "Nie oczekujcie od dnia tego, co mogą dać jedynie lata. Ale nie zapominajcie, że lata składają się z wielu dni, dlatego postanówcie, że nie zmarnujecie ani jednego.\n\nJ. M. Sailer";
		dictEN ["Quote8"] = "If opportunity doesn't knock, build a door.\n\nMilton Berle";

		dictPL ["Quote9"] = "Porażka jest po prostu okazją, by spróbować ponownie, tym razem bardziej przemyślanie.\n\nHenry Ford";
		dictEN ["Quote9"] = "We know what we are, but know not what we may be.\n\nWilliam Shakespeare";

		dictPL ["Quote10"] = "To, czego boimy się najbardziej, jest z reguły tym, co właśnie powinniśmy zrobić.\n\nRalph W. Emerson";
		dictEN ["Quote10"] = "All you need is the plan, the road map, and the courage to press on to your destination.\n\nEarl Nightingale";

		dictPL ["Quote11"] = "Nic nie jest szczególnie trudne do zrobienia, jeśli tylko rozłożyć to na etapy.\n\nHenry Ford";
		dictEN ["Quote11"] = "Your present circumstances don't determine where you can go; they merely determine where you start.\n\nNido Qubein";

		dictPL ["Quote12"] = "Życie przypomina czyste płótno: możesz wciąż je dźwigać i umrzeć pod jego ciężarem, ale jaki to ma sens? Namaluj coś na nim!\n\nOsho";
		dictEN ["Quote12"] = "It is never too late to be what you might have been.\n\nGeorge Eliot";

		dictPL ["Quote13"] = "Zacznij tam gdzie jesteś, użyj tego co masz, zrób co możesz.\n\nArthur Ashe";
		dictEN ["Quote13"] = "First they ignore you, then they laugh at you, then they fight you, then you win.\n\nMahatma Gandhi";

		dictPL ["Quote14"] = "Statki w porcie są bezpieczne, ale stanie w porcie nie jest ich przeznaczeniem.\n\nJohn Shedd";
		dictEN ["Quote14"] = "Life is 10% what happens to you and 90% how you react to it.\n\nCharles R. Swindoll";

		dictPL ["Quote15"] = "W życiu wiele ludzi wie, co robić, ale mało ludzi robi to, co wie… Nie wystarczy tylko wiedzieć! Musisz podjąć działanie.\n\nAnthony Robbins";
		dictEN ["Quote15"] = "Good, better, best. Never let it rest. 'Til your good is better and your better is best.\n\nSt. Jerome";

		dictPL ["Quote16"] = "Gdybyśmy czekali na ten jeden moment, kiedy wszystko, absolutnie wszystko jest gotowe, nigdy byśmy nic nie zaczęli.\n\nIwan Turgieniew";
		dictEN ["Quote16"] = "Live as if you were to die tomorrow. Learn as if you were to live forever.\n\nMahatma Gandhi";

		dictPL ["Quote17"] = "Być może nic nie jest warte zachodu, aby to lub tamto czynić. Ale wszystko, co czynimy, jest w każdym razie warte, aby to czynić doskonale.\n\nJohann Wolfgang von Goethe";
		dictEN ["Quote17"] = "Failure will never overtake me if my determination to succeed is strong enough.\n\nOg Mandino";

		dictPL ["Quote18"] = "Potykając się, można zajść daleko. Nie wolno tylko upaść i nie podnieść się.\n\nJohann Wolfgang von Goethe";
		dictEN ["Quote18"] = "It does not matter how slowly you go as long as you do not stop.\n\nConfucius";

		dictPL ["Quote19"] = "Przyszłość zaczyna się dzisiaj, nie jutro.\n\nJan Paweł II";
		dictEN ["Quote19"] = "In order to succeed, we must first believe that we can.\n\nNikos Kazantzakis";

		dictPL ["Quote20"] = "Dalej. Otwórz drzwi, o których mówiono, że nie da się ich otworzyć. Tam czeka życie.\n\nKelly Ann Rothaus";
		dictEN ["Quote20"] = "The secret of getting ahead is getting started.\n\nMark Twain";

		dictPL ["Quote21"] = "Najpotężniejszą siłą we wszechświecie jest siła woli.\n\nAndrzej Majewski";
		dictEN ["Quote21"] = "It always seems impossible until it's done.\n\nNelson Mandela";

		dictPL ["Quote22"] = "Ludzie, którzy nie wierzą w sukces, nie wygrywają.\n\nWłodzimierz Szaranowicz";
		dictEN ["Quote22"] = "Our greatest weakness lies in giving up. The most certain way to succeed is always to try just one more time.\n\nThomas A. Edison";

		dictPL ["Quote23"] = "Cel jest to marzenie z datą wykonania.\n\nNapoleon Hill";
		dictEN ["Quote23"] = "Problems are not stop signs, they are guidelines.\n\nRobert H. Schuller";

		dictPL ["Quote24"] = "Cokolwiek potrafisz lub myślisz, że potrafisz, rozpocznij to. Odwaga ma w sobie geniusz, potęgę i magię.\n\nJohann Wolfgang von Goethe";
		dictEN ["Quote24"] = "Keep your eyes on the stars, and your feet on the ground.\n\nTheodore Roosevelt";

		dictPL ["Quote25"] = "Jesteś projektantem swojego przeznaczenia. Jesteś jego autorem. Sam piszesz historię. Pióro tkwi w Twoim ręku, a wynik zależy od tego, co wybierzesz.\n\nLisa Nichols";
		dictEN ["Quote25"] = "Quality is not an act, it is a habit.\n\nAristotle";

		dictPL ["Quote26"] = "Wyobraźnia jest początkiem tworzenia. Wyobrażasz sobie to, czego pragniesz, chcesz tego, co sobie wyobraziłeś, i w końcu tworzysz to, czego chcesz.\n\nGeorge Bernard Shaw";
		dictEN ["Quote26"] = "If you're going through hell, keep going.\n\nWinston Churchill";

		dictPL ["Quote27"] = "Motywacja jest tym, co pozwala Ci zacząć. Nawyk jest tym, co pozwala Ci wytrwać.\n\nJim Ryun";
		dictEN ["Quote27"] = "You can't cross the sea merely by standing and staring at the water.\n\nRabindranath Tagore";

		dictPL ["Quote28"] = "Najlepszy czas na działanie jest teraz!\n\nMark Fisher";
		dictEN ["Quote28"] = "If you want to conquer fear, don't sit home and think about it. Go out and get busy.\n\nDale Carnegie";

		dictPL ["Quote29"] = "Prawdziwa decyzja jest mierzona poprzez fakt podjęcia nowego działania. Jeśli nie ma działania tak naprawdę nie podjąłeś decyzji.\n\nTony Robbins";
		dictEN ["Quote29"] = "The way to get started is to quit talking and begin doing.\n\nWalt Disney";

		dictPL ["Quote30"] = "W konfrontacji strumienia ze skałą, strumień zawsze wygrywa - nie przez swoją siłę, ale przez wytrwałość.\n\nBudda";
		dictEN ["Quote30"] = "By failing to prepare, you are preparing to fail.\n\nBenjamin Franklin";

		dictPL ["Quote31"] = "Mędrcami są ci, który dochodzą do prawdy przez błędy. Ci, którzy upierają się przy błędach, są głupcami.\n\nFriedrich Ruckert";
		dictEN ["Quote31"] = "Without hard work, nothing grows but weeds.\n\nGordon B. Hinckley";

		dictPL ["Quote32"] = "Dopóki nie uczynisz nieświadomego świadomym, będzie ono kierowało Twoim życiem, a Ty będziesz nazywał to przeznaczeniem.\n\nCarl Gustav Jung";
		dictEN ["Quote32"] = "Knowing is not enough; we must apply. Willing is not enough; we must do.\n\nJohann Wolfgang von Goethe";

		dictPL ["Quote33"] = "Jesteś jedyną osobą na świecie, która może wykorzystać Twój potencjał.\n\nZig Ziglar";
		dictEN ["Quote33"] = "Ever tried. Ever failed. No matter. Try Again. Fail again. Fail better.\n\nSamuel Beckett";

		dictPL ["Quote34"] = "Pamiętaj, że mamy do czynienia jedynie z myślami, a myśli mogą zostać zmienione. Gdy zmieniamy nasze myślenie, zmieniamy naszą rzeczywistość.\n\nLouise L. Hay";
		dictEN ["Quote34"] = "The most effective way to do it, is to do it.\n\nAmelia Earhart";

		dictPL ["Quote35"] = "Być zwyciężonym i nie ulec to zwycięstwo. Zwyciężyć i osiąść na laurach to klęska.\n\nJózef Piłsudski";
		dictEN ["Quote35"] = "To be defeated and not submit, is victory. To be victorious and rest on one's laurels, is defeat.\n\nJózef Piłsudski";

		dictPL ["Quote36"] = "Mówisz, że możesz – to możesz. Mówisz, że nie możesz – to nie możesz. Więc sobie wybierz.\n\nMistrz Zen Seung Sahn";
		dictEN ["Quote36"] = "Either I will find a way, or I will make one.\n\nPhilip Sidney";



	}



	// Use this for initialization
	void Start () {
	//	print ("start: PlayerPrefs.HasKey('firstRunDone'): " + PlayerPrefs.HasKey ("firstRunDone"));

		lang = "en";

		dictPL = new Dictionary<string,string> ();
		dictEN = new Dictionary<string,string> ();

		InitDicts ();
		LoadLangs ();

		bool levelsLocked = true;

		if(!PlayerPrefs.HasKey("firstRunDone")){
			//zainicjuj
			PlayerPrefs.SetInt("firstRunDone",1);
			PlayerPrefs.SetString ("lang", "en");
			PlayerPrefs.SetInt ("tutorial", 0);
			PlayerPrefs.SetInt ("sound", 1);
			PlayerPrefs.SetInt ("level1", 1);

			if (levelsLocked) {

				PlayerPrefs.SetInt ("level2", 0);
				PlayerPrefs.SetInt ("level3", 0);
				PlayerPrefs.SetInt ("level4", 0);
				PlayerPrefs.SetInt ("level5", 0);
				PlayerPrefs.SetInt ("level6", 0);
				PlayerPrefs.SetInt ("level7", 0);
				PlayerPrefs.SetInt ("level8", 0);
				PlayerPrefs.SetInt ("level9", 0);
				PlayerPrefs.SetInt ("level10", 0);
				PlayerPrefs.SetInt ("level11", 0);
				PlayerPrefs.SetInt ("level12", 0);
				PlayerPrefs.SetInt ("level13", 0);
				PlayerPrefs.SetInt ("level14", 0);
				PlayerPrefs.SetInt ("level15", 0);
				PlayerPrefs.SetInt ("level16", 0);
				PlayerPrefs.SetInt ("level17", 0);
				PlayerPrefs.SetInt ("level18", 0);
				PlayerPrefs.SetInt ("level19", 0);
				PlayerPrefs.SetInt ("level20", 0);
				PlayerPrefs.SetInt ("level21", 0);
				PlayerPrefs.SetInt ("level22", 0);
				PlayerPrefs.SetInt ("level23", 0);
				PlayerPrefs.SetInt ("level24", 0);
				PlayerPrefs.SetInt ("level25", 0);
				PlayerPrefs.SetInt ("level26", 0);
				PlayerPrefs.SetInt ("level27", 0);
				PlayerPrefs.SetInt ("level28", 0);
				PlayerPrefs.SetInt ("level29", 0);
				PlayerPrefs.SetInt ("level30", 0);
				PlayerPrefs.SetInt ("level31", 0);
				PlayerPrefs.SetInt ("level32", 0);
				PlayerPrefs.SetInt ("level33", 0);
				PlayerPrefs.SetInt ("level34", 0);
				PlayerPrefs.SetInt ("level35", 0);
				PlayerPrefs.SetInt ("level36", 0);
			} else {//levels unlocked

				PlayerPrefs.SetInt ("level2", 1);
				PlayerPrefs.SetInt ("level3", 1);
				PlayerPrefs.SetInt ("level4", 1);
				PlayerPrefs.SetInt ("level5", 1);
				PlayerPrefs.SetInt ("level6", 1);
				PlayerPrefs.SetInt ("level7", 1);
				PlayerPrefs.SetInt ("level8", 1);
				PlayerPrefs.SetInt ("level9", 1);
				PlayerPrefs.SetInt ("level10", 1);
				PlayerPrefs.SetInt ("level11", 1);
				PlayerPrefs.SetInt ("level12", 1);
				PlayerPrefs.SetInt ("level13", 1);
				PlayerPrefs.SetInt ("level14", 1);
				PlayerPrefs.SetInt ("level15", 1);
				PlayerPrefs.SetInt ("level16", 1);
				PlayerPrefs.SetInt ("level17", 1);
				PlayerPrefs.SetInt ("level18", 1);
				PlayerPrefs.SetInt ("level19", 1);
				PlayerPrefs.SetInt ("level20", 1);
				PlayerPrefs.SetInt ("level21", 1);
				PlayerPrefs.SetInt ("level22", 1);
				PlayerPrefs.SetInt ("level23", 1);
				PlayerPrefs.SetInt ("level24", 1);
				PlayerPrefs.SetInt ("level25", 1);
				PlayerPrefs.SetInt ("level26", 1);
				PlayerPrefs.SetInt ("level27", 1);
				PlayerPrefs.SetInt ("level28", 1);
				PlayerPrefs.SetInt ("level29", 1);
				PlayerPrefs.SetInt ("level30", 1);
				PlayerPrefs.SetInt ("level31", 1);
				PlayerPrefs.SetInt ("level32", 1);
				PlayerPrefs.SetInt ("level33", 1);
				PlayerPrefs.SetInt ("level34", 1);
				PlayerPrefs.SetInt ("level35", 1);
				PlayerPrefs.SetInt ("level36", 1);

			}
			PlayerPrefs.SetInt ("quote1", 0);
			PlayerPrefs.SetInt ("quote2", 0);
			PlayerPrefs.SetInt ("quote3", 0);
			PlayerPrefs.SetInt ("quote4", 0);
			PlayerPrefs.SetInt ("quote5", 0);
			PlayerPrefs.SetInt ("quote6", 0);
			PlayerPrefs.SetInt ("quote7", 0);
			PlayerPrefs.SetInt ("quote8", 0);
			PlayerPrefs.SetInt ("quote9", 0);
			PlayerPrefs.SetInt ("quote10", 0);
			PlayerPrefs.SetInt ("quote11", 0);
			PlayerPrefs.SetInt ("quote12", 0);
			PlayerPrefs.SetInt ("quote13", 0);
			PlayerPrefs.SetInt ("quote14", 0);
			PlayerPrefs.SetInt ("quote15", 0);
			PlayerPrefs.SetInt ("quote16", 0);
			PlayerPrefs.SetInt ("quote17", 0);
			PlayerPrefs.SetInt ("quote18", 0);
			PlayerPrefs.SetInt ("quote19", 0);
			PlayerPrefs.SetInt ("quote20", 0);
			PlayerPrefs.SetInt ("quote21", 0);
			PlayerPrefs.SetInt ("quote22", 0);
			PlayerPrefs.SetInt ("quote23", 0);
			PlayerPrefs.SetInt ("quote24", 0);
			PlayerPrefs.SetInt ("quote25", 0);
			PlayerPrefs.SetInt ("quote26", 0);
			PlayerPrefs.SetInt ("quote27", 0);
			PlayerPrefs.SetInt ("quote28", 0);
			PlayerPrefs.SetInt ("quote29", 0);
			PlayerPrefs.SetInt ("quote30", 0);
			PlayerPrefs.SetInt ("quote31", 0);
			PlayerPrefs.SetInt ("quote32", 0);
			PlayerPrefs.SetInt ("quote33", 0);
			PlayerPrefs.SetInt ("quote34", 0);
			PlayerPrefs.SetInt ("quote35", 0);
			PlayerPrefs.SetInt ("quote36", 0);
			PlayerPrefs.Save ();
		}
	//	print ("start: PlayerPrefs.HasKey('firstRunDone'): " + PlayerPrefs.HasKey ("firstRunDone"));
			//odczytaj
			lang=PlayerPrefs.GetString ("lang");
			sound=PlayerPrefs.GetInt ("sound");
			levelsUnlocks[0]=PlayerPrefs.GetInt ("level1");
			levelsUnlocks[1]=PlayerPrefs.GetInt ("level2");
			levelsUnlocks[2]=PlayerPrefs.GetInt ("level3");
			levelsUnlocks[3]=PlayerPrefs.GetInt ("level4");
			levelsUnlocks[4]=PlayerPrefs.GetInt ("level5");
			levelsUnlocks[5]=PlayerPrefs.GetInt ("level6");
			levelsUnlocks[6]=PlayerPrefs.GetInt ("level7");
			levelsUnlocks[7]=PlayerPrefs.GetInt ("level8");
			levelsUnlocks[8]=PlayerPrefs.GetInt ("level9");
			levelsUnlocks[9]=PlayerPrefs.GetInt ("level10");
			levelsUnlocks[10]=PlayerPrefs.GetInt ("level11");
			levelsUnlocks[11]=PlayerPrefs.GetInt ("level12");
			levelsUnlocks[12]=PlayerPrefs.GetInt ("level13");
			levelsUnlocks[13]=PlayerPrefs.GetInt ("level14");
			levelsUnlocks[14]=PlayerPrefs.GetInt ("level15");
			levelsUnlocks[15]=PlayerPrefs.GetInt ("level16");
			levelsUnlocks[16]=PlayerPrefs.GetInt ("level17");
			levelsUnlocks[17]=PlayerPrefs.GetInt ("level18");
			levelsUnlocks[18]=PlayerPrefs.GetInt ("level19");
			levelsUnlocks[19]=PlayerPrefs.GetInt ("level20");
			levelsUnlocks[20]=PlayerPrefs.GetInt ("level21");
			levelsUnlocks[21]=PlayerPrefs.GetInt ("level22");
			levelsUnlocks[22]=PlayerPrefs.GetInt ("level23");
			levelsUnlocks[23]=PlayerPrefs.GetInt ("level24");
			levelsUnlocks[24]=PlayerPrefs.GetInt ("level25");
			levelsUnlocks[25]=PlayerPrefs.GetInt ("level26");
			levelsUnlocks[26]=PlayerPrefs.GetInt ("level27");
			levelsUnlocks[27]=PlayerPrefs.GetInt ("level28");
			levelsUnlocks[28]=PlayerPrefs.GetInt ("level29");
			levelsUnlocks[29]=PlayerPrefs.GetInt ("level30");
			levelsUnlocks[30]=PlayerPrefs.GetInt ("level31");
			levelsUnlocks[31]=PlayerPrefs.GetInt ("level32");
			levelsUnlocks[32]=PlayerPrefs.GetInt ("level33");
			levelsUnlocks[33]=PlayerPrefs.GetInt ("level34");
			levelsUnlocks[34]=PlayerPrefs.GetInt ("level35");
			levelsUnlocks[35]=PlayerPrefs.GetInt ("level36");
	
		/*if (PlayerPrefs.GetInt ("sound") == 0) {
			foreach (GameObject g in soundSources) {
				g.GetComponent<AudioSource> ().volume = 0;
			}
		} else {
			if (PlayerPrefs.GetInt ("sound") == 0) {
				foreach (GameObject g in soundSources) {
					g.GetComponent<AudioSource> ().volume = 1;
				}
			} else {
				print ("blad, sound w playerprefs jest: " +	PlayerPrefs.GetInt ("sound"));
			}
		}*/

		SoundOnOff ();
		//lang = "pl";//normalnie pobierz z playerprefab

	}

	// Update is called once per frame
	void Update () {
		
	}
}
