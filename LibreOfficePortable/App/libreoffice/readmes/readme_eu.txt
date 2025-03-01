
======================================================================
LibreOffice 24.2 ReadMe
======================================================================


Readme fitxategi honen azken aldaketak ikusteko, joan https://git.libreoffice.org/core/tree/master/README.md gunera.

Fitxategi honek LibreOffice softwareari buruzko informazio garrantzitsua du. Informazio hau arretaz irakurtzea gomendatzen dizugu instalazioari ekin baino lehen.

LibreOffice komunitateak du produktu honen garapenaren ardura, eta komunitatearen kide izatera eta parte hartzera gonbidatzen dizu. Erabiltzaile berria bazara, LibreOffice produktuaren webgunea bisita dezakezu LibreOffice proiektuari eta haren inguruan dauden komunitateei buruzko informazio gehiago jasotzeko. Joan https://www.libreoffice.org/ helbidera.

Edozein erabiltzailerentzako benetan doakoa al da LibreOffice?
----------------------------------------------------------------------

Edozeinek erabil dezake LibreOffice askatasun osoarekin. LibreOffice kopia hau hartu eta zuk nahi dituzun ordenagailu guztietan instala dezakezu, eta nahi duzunerako erabili (erabilera komertzialerako, gobernuan, administrazio publikoan edo hezkuntzarako barne). Xehetasun gehiagorako, irakurri LibreOffice deskarga honen paketean dagoen lizentziaren testua.

Zergatik da edonorentzako doakoa LibreOffice?
----------------------------------------------------------------------

Inongo kargurik gabe erabili dezakezu LibreOffice banako laguntzaileek zein esponsor korporatibo ugarik diseinatu, garatu, probatu, itzuli, dokumentatu, sostengatu, merkaturatu, eta beste hainbat modutan lagundu dutelako gaur egun dena izan dadin LibreOffice - etxerako eta bulegorako munduko kodigo irekiko produktibitate-software nagusia.

Haien ahaleginak eskertzen badituzu, eta LibreOffice etorkizunean ere erabilgarri egotea nahi baduzu, proiektuari laguntza eman diezaiokezu - ikus https://www.documentfoundation.org/contribution/ xehetasun gehiagorako. Edozeinek egin ditzake edozein motako ekarpenak.

----------------------------------------------------------------------
Instalazioari buruzko oharrak
----------------------------------------------------------------------

LibreOffice produktuak Java Runtime Environment (JRE) bertsio berria behar du funtzionaltasun osoarekin aritzeko. JRE ez da LibreOffice(e)n instalazio-paketearen atal bat, aparte instalatu behar da.

Sistemaren eskakizunak
----------------------------------------------------------------------

* Microsoft Windows 7 SP1, 8, 8.1 eguneraketa (S14) edo 10

Kontuan izan administrazio-eskubideak behar direla instalazio-prozesua egiteko.

LibreOffice aplikazio lehenetsi gisa erregistratzea Microsoft Officen formatuentzako derrigortu edo ken daiteke instalatzailearen honako komando-lerroko aldatzaileekin:

* REGISTER_ALL_MSO_TYPES=1 bidez LibreOffice Microsoft Office formatuetarako aplikazio lehenetsia izateko erregistra dadin behartuko da.
* REGISTER_NO_MSO_TYPES=1 bidez ez da behartuko LibreOffice Microsoft Office formatuetarako aplikazio lehenetsia izateko erregistra dadin.

Ziurtatu nahiko memoria libre duzula zure sistemaren aldi baterako direktorioan, eta ziurtatu irakurtzeko, idazteko eta exekutatzeko baimenak ongi daudela. Itxi beste programa guztiak instalazio-prozesuari ekin baino lehen.

LibreOffice Debian/Ubuntu oinarriko Linux-sistemetan instalatzea
----------------------------------------------------------------------

LibreOffice(e)n ingeleseko bertsioa (US English) instalatu baduzu eta ondoren beste hizkuntza-pakete bat instalatu nahi baduzu, irakurri 'Hizkuntza-pakete bat instalatzea' atala.

Deskargatutako fitxategia deskonprimatzen duzunean, edukiak azpidirektorio batean deskonprimatu direla ikusiko duzu. Ireki zure fitxategi-arakatzailearen leiho bat eta joan "LibreOffice_" testuarekin hasten den izena duen direktoriora. Izenean bertsio-zenbakia eta plataformari buruzko informazioa ere ikusiko duzu.

Direktorioak "DEBS" deitzen den azpidirektorio bat du. Joan "DEBS" direktorio horretara.

Egin klik eskuineko botoiaz direktorio barruan eta hautatu "Ireki terminalean". Terminal-leiho bat irekiko da. Terminal-leihoaren komando-lerrotik, sartu honako komandoa (erro-erabiltzailearen pasahitza sartu beharko duzu komandoa exekutatzeko):

Honako komandoek LibreOffice eta mahaigain-integrazioko paketeak instalatuko ditu (horiek idazten saiatu baino, kopiatu eta terminalean itsats ditzakezu):

sudo dpkg -i *.deb

Burutu da jada instalazio-prozesua, eta LibreOffice aplikazio guztien ikurrak eduki beharko zenituzke zure mahaigainaren Aplikazioak/Bulegoa menuan.

LibreOffice Fedoran, openSUSEn, Mandrivan eta beste Linux sistema batzuetan instalatzea RPM paketeak erabiliz
----------------------------------------------------------------------

LibreOffice(e)n ingeleseko bertsioa (US English) instalatu baduzu eta ondoren beste hizkuntza-pakete bat instalatu nahi baduzu, irakurri 'Hizkuntza-pakete bat instalatzea' atala.

Deskargatutako fitxategia deskonprimatzen duzunean, edukiak azpidirektorio batean deskonprimatu direla ikusiko duzu. Ireki zure fitxategi-arakatzailearen leiho bat eta joan "LibreOffice_" testuarekin hasten den izena duen direktoriora. Izenean bertsio-zenbakia eta plataformari buruzko informazioa ere ikusiko duzu.

Direktorioak "RPMS" deitzen den azpidirektorio bat du. Joan "RPMS" direktorio horretara.

Egin klik eskuineko botoiaz direktorio barruan eta hautatu "Ireki terminalean". Terminal-leiho bat irekiko da. Terminal-leihoaren komando-lerrotik, sartu honako komandoa (erro-erabiltzailearen pasahitza sartu beharko duzu komandoa exekutatzeko):

Fedoran oinarritutako sistemetan: sudo dnf install *.rpm

Mandriva oinarriko sistemetarako: sudo urpmi *.rpm

RPM formatuan oinarritutako beste sistema batzuetan (openSUSE, etab.): rpm -Uvh *.rpm

Burutu da jada instalazio-prozesua, eta LibreOffice aplikazio guztien ikurrak eduki beharko zenituzke zure mahaigainaren Aplikazioak/Bulegoa menuan.

Bestela, instalazioa erabiltzaile gisa egin nahi baduzu, fitxategi honetako maila goreneko direktorioan dagoen 'install' scripta erabil dezakezu. Scriptak LibreOffice konfiguratuko du instalazio honetan profil propioa izan dezan, zure LibreOffice profil normaletik aparte. Kontuan izan honek ez duela instalatuko sistema-integraziorako atalak, esaterako menu-elementuak eta mahaigainaren MIME moten erregistroa.

Goiko instalazio-argibideetan aipatu ez diren Linux banaketen mahaigainetan integratzeko oharrak
----------------------------------------------------------------------

Erraza izan beharko luke LibreOffice instalazio-argibide hauetan azaltzen ez diren beste Linux banaketa batzuetan instalatzea. Desberdintasun nagusienak mahaigaineko integrazioan egongo dira.

RPMS (edo DEBS) direktorioan badago libreoffice24.2-freedesktop-menus-24.2.0.1-1.noarch.rpm (edo libreoffice24.2-debian-menus_24.2.0.1-1_all.deb edo antzeko zerbait) izena duen pakete bat ere. Freedesktop.org espezifikazioak/gomendioak (https://en.wikipedia.org/wiki/Freedesktop.org) jarraitzen dituzten Linux banaketa guztietarako da pakete hau, eta goian aipatu ez diren beste Linux banaketetan instalatzeko erabil daiteke.

Hizkuntza-pakete bat instalatzea
----------------------------------------------------------------------

Deskargatu zure hizkuntzarako eta plataformarako egokia den hizkuntza-paketea. Instalazio-fitxategi nagusia dagoen kokaleku berean dago eskuragarri. Nautilus fitxategi-kudeatzailea erabiliz, erauzi deskargatutako fitxategikoak direktorio batera (adibidez, zure mahaiganera). Ziurtatu LibreOffice aplikazio guztietatn irten zarela (baita abiarazle bizkorretik, abiarazita badago).

Joan zaitez deskargatu duzun hizkuntza-paketea erauzi duzun direktoriora.

Orain joan erauzketa-prozesuan sortu den direktoriora. Esaterako, 32 biteko Debian/Ubuntu oinarriko sistema baterako frantsesezko hizkuntza-paketean, direktorioaren izena hau izango da:  LibreOffice_, gehi bertsioaren informazioa, gehi Linux_x86_langpack-deb_fr.

Orain joan instalatuko diren paketeak dituen direktoriora. Debian/Ubuntu oinarriko sistemetan, direktorioaren izena DEBS izango da. Fedoran, openSUSEn edo Madrivan, direktorioa RPMS izango da.

Nautilus fitxategi-kudeatzailea erabiliz, egin klik eskuineko botoiaz direktorioan eta hautatu "Ireki terminalean" komandoa. Ireki berri duzun terminal-leihoan, exekutatu hizkuntza-paketea instalatzeko komandoa (beheko komando guztiekin, askotan zure erro-erabiltzailearen pasahitza sartzeko eskatuko dizu sistemak):

Debian/Ubuntu oinarriko sistemetarako: sudo dpkg -i *.deb

Fedoran oinarritutako sistemetan: su -c 'dnf install *.rpm'

Mandriva oinarriko sistemetarako: sudo urpmi *.rpm

RPM erabiltzen duten beste sistema batzuetan (openSUSE, eta.): rpm -Uvh *.rpm

Now start one of the LibreOffice applications - Writer, for instance. Go to the Tools menu and choose Options. In the Options dialog box, click on "Languages and Locales" and then click on "General". Dropdown the "User interface" list and select the language you just installed. If you want, do the same thing for the "Locale setting", the "Default currency", and the "Default languages for documents".

Ezarpen horiek doitu ondoren, sakatu Ados. Elkarrizketa-koadroa itxiko da, eta zure aldaketak LibreOffice utzi eta berriro abiarazi ondoren aktibatuko direla dioen mezu bat ikusiko duzu (gogoan izan abiarazle azkarretik ere irtetea, abian badago).

LibreOffice abiarazten duzun hurrengoan, instalatu-berri duzun hizkuntzan abiaraziko da.

----------------------------------------------------------------------
Arazoak programa abiaraztean
----------------------------------------------------------------------

LibreOffice abiaraztean (adibidez, aplikazioak blokeatzea) edo pantailarekin arazoak agertzen badira, sarritan erruduna txartel grafikoaren kontrolatzailea izaten da. Arazo horiek badituzu, eguneratu txartel grafikoaren kontrolatzailea edo saiatu zure sistema eragileak eskaintzen dizun kontrolatzailea erabiltzen.

----------------------------------------------------------------------
ALPS touchpad-ak/touchpad sinaptikoak Windows-en
----------------------------------------------------------------------

Windows-en kontrolatzaile-arazo baten ondorioz, ezin duzu LibreOffice dokumentuetan behatzarekin korritu ALPS touchpad-ak/touchpad sinaptikoak erabiliz.

Touchpad bidez korritzea gaitzeko, gehitu honako lerroak C:\Program Files\Synaptics\SynTP\SynTPEnh.ini konfigurazio-fitxategian eta berrabiarazi ordenagailua:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Baliteke konfigurazio-fitxategiaren kokalekua ezberdina izatea Windows-en bertsioaren arabera.

----------------------------------------------------------------------
Laster-teklak
----------------------------------------------------------------------

Sistema eragileak erabiltzen ez dituen laster-teklak (tekla-konbinazioak) besterik ezin ditu erabili LibreOffice aplikazioak. LibreOffice aplikazio bateko tekla-konbinazio batek ez badu funtzionatzen LibreOffice laguntzan deskribatu bezala, egiaztatu sistema eragilea ez dela laster-tekla hori erabiltzen ari. Gatazka horiek saihesteko, zure sistema eragileak esleitutako teklak alda ditzakezu. Bestela, LibreOffice aplikazioko ia edozein tekla-esleipen ere alda dezakezu. Gai horren inguruko informazio gehiago jasotzeko, ikusi LibreOffice laguntza edo zure sistema eragilearen laguntza-dokumentazioa.

----------------------------------------------------------------------
Arazoak dokumentuak posta elektroniko gisa bidaltzean LibreOffice(e)tik
----------------------------------------------------------------------

Dokumentu bat 'Fitxategia - Bidali - Dokumentua posta elektronikoko mezu gisa' edo 'Fitxategia - Bidali - Dokumentua PDF eranskin gisa' aukeren bidez bidaltzean, arazoak gerta daitezke (programa kraskatzea edo blokeatzea). Windows fitxategi-sistemaren "Mapi" (Messaging Application Programming Interface) izan daiteke arazo horren jatorria, zenbait fitxategi-bertsiotan arazoak eragiten baititu. Zoritxarrez, arazoa ezin izan da osoki mugatu bertsio batera. Informazio gehiago jasotzeko, joan https://www.microsoft.com webgunera eta bilatu "mapi dll" 'Microsoft Knowledge Base' atalean.

----------------------------------------------------------------------
Erabilerraztasunaren ohar garrantzitsuak
----------------------------------------------------------------------

LibreOffice aplikazioaren erabilerraztasun-ezaugarrien inguruko informazio gehiago eskuratzeko, irakurri https://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Erabiltzailearentzako laguntza
----------------------------------------------------------------------

Laguntzarako webgune nagusiak LibreOffice erabiltzean egon daitezkeen galderetarako erantzuna eduki dezake. Zure galderari beharbada jadanik erantzuna eman diote - begiratu komunitatearen foroa https://www.documentfoundation.org/nabble/ helbidean edo egin bilaketak 'users@libreoffice.org' posta-zerrendako fitxategien artean https://www.libreoffice.org/lists/users/ helbidean. Bestela, zure galderak users@libreoffice.org posta-zerrendan ere bota ditzakezu. Zerrendan izena eman nahi baduzu (posta bidezko erantzunak jasotzeko), bidali posta bat hona: users+subscribe@libreoffice.org.

Begiratu, baita ere, LibreOffice webguneko ohiko galderen atala.

----------------------------------------------------------------------
Akatsak & bestelako arazoak jakinaraztea
----------------------------------------------------------------------

Akatsak jakinarazi eta konpontzeko darabilgun sistema Bugzilla da, https://bugs.documentfoundation.org/ webgunean ostatatuta dagoena. Erabiltzaile guztiak animatzen ditugu bertan parte hartzera eta nork bere plataforman aurki ditzakeen akatsak jakinaraztera. Akatsen jakinarazpen bizia da erabiltzaileen komunitateak LibreOffice hobetzeko abian den etengabeko garapenerako egin dezakeen ekarpenik garrantzitsuenetako bat.

----------------------------------------------------------------------
Parte-hartzea
----------------------------------------------------------------------

LibreOffice komunitatearentzat oso onuragarria izango litzateke zuk iturburu irekiko proiektu garrantzitsu honen garapenean aktiboki parte hartzea.

Erabiltzaile gisa, suitearen garapen-prozesuaren atal garrantzitsua zara jadanik, eta zeregin aktiboagoa har dezazun animatzen dizugu, komunitatearen epe luzeko laguntzailea bihur zaitezen. Egin bat gurekin eta begiratu ekarpenen orrian, LibreOffice webgunearen barruan, ea zer egin dezakezun.

Nola hasi
----------------------------------------------------------------------

Laguntzen hasteko biderik onena da posta-zerrendetan izena ematea, mezu-trukeak irakurtzen hastea eta pixkanaka posta-artxibatzaileak erabiltzea bertan aztertzen diren hamaika gaiak ezagutzen joateko, LibreOffice lehen aldiz 2000ko urrian argitaratu zenez asko baitira jorratutako gaiak. Eroso zaudenean, egin behar duzun gauza bakarra da zure burua aurkezten duen posta bat bidaltzea eta lanean hastea. Kode irekiko proiektuak ezagutzen badituzu, begiratu egin beharrekoen zerrenda LibreOfficen webgunean eta ikusi ea non lagun dezakezun.

Harpidetzea
----------------------------------------------------------------------

Hemen dituzu harpidetu zaitezkeen posta-zerrendetako batzuk: https://www.libreoffice.org/get-help/mailing-lists/

* Notiziak: announce@documentfoundation.org *erabiltzaile guztientzako gomendatua* (trafiko arina)
* Erabiltzaileen zerrenda nagusia: users@global.libreoffice.org *eztabaidetan kuxkuxeatzeko modu erraza* (mezu-truke bizia)
* Marketing proiektua: marketing@global.libreoffice.org *garapenaz haratago* (gero eta mezu gehiago)
* Garatzaile-zerrenda orokorra: libreoffice@lists.freedesktop.org (mezu-truke latza)

Proiektu bat edo gehiagorekin bat egitea
----------------------------------------------------------------------

Ekarpen garrantzitsuak egin diezazkiokezu kode irekiko proiektu garrantzitsu honi, berdin dio softwarearen diseinuan edo kodea idaztean eskarmentu asko duzun ala ez. Bai, zuk!

LibreOffice 24.2(r)ekin lanean gustura arituko zarela eta linean gurekin bat egingo duzula espero dugu.

LibreOffice komunitatea

----------------------------------------------------------------------
Erabilitako/aldatutako iturburu-kodea
----------------------------------------------------------------------

Zati batzuk Copyright 1998, 1999 James Clark. Zati batzuk Copyright 1996, 1998 Netscape Communications Corporation.
