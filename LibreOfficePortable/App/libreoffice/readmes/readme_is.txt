
======================================================================
Lesefni LibreOffice 24.2
======================================================================


Til að sjá allra nýjustu uppfærslur við þetta skjal, er hægt að skoða https://git.libreoffice.org/core/tree/master/README.md

Þetta skjal inniheldur mikilvægar upplýsingar um LibreOffice hugbúnaðinn. Endilega lestu þær gaumgæfilega áður en þú byrjar að vinna með hann.

LibreOffice samfélagið er ábyrgt fyrir þróun þessa hugbúnaðar, við bjóðum þér að taka þátt í þessu með okkur - ef þú hefur áhuga. Sértu alveg nýr notandi geturðu heimsótt LibreOffice vefinn, þar geturðu fundið mikið af upplýsingum um LibreOffice verkefnið og samfélagið í kringum það. Farðu á https://www.libreoffice.org/.

Er LibreOffice í alvörunni ókeypis fyrir alla?
----------------------------------------------------------------------

LibreOffice er frjáls hverjum sem er til notkunar, án endurgjalds. Þú mátt taka þetta eintak af LibreOffice og setja upp á eins mörgum tölvum og þú vilt, nota í hvaða tilgangi sem þér dettur í hug (þar með talin viðskipti, ríkisrekstur, almenningsafnot og notkun í skólum). Til að skoða ítarlegri atriði í þessu sambandi má lesa texta notendaleyfisins sem fylgdi LibreOffice pakkanum.

Hversvegna er LibreOffice ókeypis fyrir alla?
----------------------------------------------------------------------

Þú getur í dag notað þetta eintak af LibreOffice án nokkurs endurgjalds vegna þess að einstaklingar og fyrirtæki hafa hannað, þróað, prófað, þýtt, skrifað um, stutt við, kynnt og hjálpað til við á marga vegu við að gera LibreOffice að því sem það er í dag - fremsta opna skrifstofuhugbúnaðnum.

Ef þú kannt að meta þessa vinnu og vilt tryggja að LibreOffice haldi áfram að vera fáanlegt í framtíðinni, endilega íhugaðu að taka þátt og gefa af þér til verkefnisins - skoðaðu til dæmis https://www.documentfoundation.org/contribution/ fyrir nánari upplýsingar. Allir geta gefið eitthvað í púkkið.

----------------------------------------------------------------------
Athugasemdir um uppsetningu
----------------------------------------------------------------------

LibreOffice þarfnast nýlegrar útgáfu af Java keyrsluumhverfinu (JRE) til að ná öllum eiginleikum kerfisins. JRE er ekki hluti af LibreOffice uppsetningarpakkanum, heldur þarf að setja það upp sérstaklega.

Kerfiskröfur
----------------------------------------------------------------------

* Microsoft Windows 7 SP1, 8, 8.1 uppfærsla (S14) eða 10

Athugið: Það þarf kerfisstjóraréttindi (administrator) við uppsetninguna.

Kerfisskráningu LibreOffice sem sjálfgefinna forrita til meðhöndlunar á Microsoft Office skráasniðum er hægt að þvinga fram eða sleppa alveg með því að nota eftirfarandi rofa á skipanalínu með ræsingu uppsetningarforritsins:

* REGISTER_ALL_MSO_TYPES=1 þvingar kerfisskráningu LibreOffice sem sjálfgefinna forrita fyrir Microsoft Office skjalasnið.
* REGISTER_NO_MSO_TYPES=1 sleppir kerfisskráningu LibreOffice sem sjálfgefinna forrita fyrir Microsoft Office skjalasnið.

Gakktu úr skugga um að þú hafir nægilegt laust pláss í bráðabirgðamöppu kerfisins og að les-, skrif- og keyrsluréttindi hafi verið veitt. Lokaðu öllum öðrum forritum áður en uppsetningaferlið er ræst.

Uppsetning LibreOffice á Linux dreifingar sem byggjast á Debian/Ubuntu
----------------------------------------------------------------------

Til að sjá leiðbeiningar um hvernig setja eigi upp tungumálapakka (eftir að hafa sett upp ensku (US English) útgáfuna af LibreOffice), lestu þá greinina hér fyrir neðan sem heitir Uppsetning tungumálapakka.

Þegar þú afpakkar safnskránni sem þú náðir í, ættirðu að sjá að innihaldinu hefur verið afþjappað í undirmöppu. Opnaðu skráastjóraglugga og farðu inn í þessa möppu, heiti hennar ætti að byrja á "LibreOffice_" að viðbættum upplýsingum um útgáfu og stýrikerfi.

Mappan inniheldur undirmöppu sem kallast "DEBS". Farðu inn í "DEBS" möppuna.

Hægrismelltu innan í möppunni og veldu "Opna í skjáhermi". Skjáhermir getur einnig veriðkallaður "Útstöð" eða "Skel". Í glugganum sem opnast er svokölluð skipanalína, á hana skrifarðu eftirfarandi skipun (þú verður spurð/ur um rótarlykilorðið áður en skipunin er framkvæmd):

Eftirfarandi skipanir munu setja inn LibreOffice og tengda skjáborðsaðgerðapakka (þú ættir kannski að afrita og líma þær inn í skjáhermiforrit fremur en að hamra þær inn):

sudo dpkg -i *.deb

Uppsetningarferlinu er núna lokið og þú ættir að sjá táknmyndir fyrir öll LibreOffice forritin undir valmyndinni Forrit/Skrifstofuforrit (Applications/Office).

Uppsetning LibreOffice á Fedora, Suse, Mandriva og öðrum Linux dreifingum sem nota RPM pakka
----------------------------------------------------------------------

Til að sjá leiðbeiningar um hvernig setja eigi upp tungumálapakka (eftir að hafa sett upp ensku (US English) útgáfuna af LibreOffice), lestu þá greinina hér fyrir neðan sem heitir Uppsetning tungumálapakka.

Þegar þú afþjappar safnskránni sem þú náðir í, muntu sjá að innihaldinu hefur verið afþjappað í undirmöppu. Opnaðu skráastjóraglugga og skiptu inn í þessa möppu, heiti hennar byrjar á "LibreOffice_" að viðbættum upplýsingum um útgáfu og stýrikerfi.

Þessi mappa inniheldur undirmöppu sem kallast "RPMS". Skiptu um staðsetningu og farðu inn í þessa "RPMS" möppu.

Hægrismelltu innan í möppunni og veldu "Opna í skjáhermi". Skjáhermir getur einnig veriðkallaður "Útstöð" eða "Skel". Í glugganum sem opnast er svokölluð skipanalína, á hana skrifarðu eftirfarandi skipun (þú verður spurð/ur um rótarlykilorðið áður en skipunin er framkvæmd):

Á kerfum sem byggjast á Fedora: sudo dnf install *.rpm

Á kerfum sem byggjast á Mandriva: sudo urpmi *.rpm

Á kerfum sem byggjast á RPM pakkakerfinu (OpenSUSE, o.s.frv.): rpm -Uvh *.rpm

Uppsetningarferlinu er núna lokið og þú ættir að sjá táknmyndir fyrir öll LibreOffice forritin undir valmyndinni Forrit/Skrifstofuforrit (Applications/Office).

Einnig geturðu notað 'install' skriftuna, sem staðsett er í rót þessarar safnskrár, til að framkvæma uppsetningu sem venjulegur notandi / user. Skriftan setur upp LibreOffice þannig að uppsetningin hefur sitt eigið notandasnið, aðskilið frá venjulega LibreOffice sniðinu.Athugaðu að þetta mun ekki setja upp kerfisaðlögunarhluta á borð við færslur í skjáborðsvalmynd eða skráavensl við MIME tegundir.

Athugasemdir varðandi samhæfingu við skjáborðsumhverfi (Desktop Integration) í Linux-dreifingum sem ekki koma fram í upplýsingunum hér að ofan
----------------------------------------------------------------------

Það ætti að vera tiltölulega einfalt að setja LibreOffice upp á aðrar Linux dreifingar en þær sem lýst er í þessum leiðbeiningum. Helsti munurinn ætti að vera að hve miklu leyti samþætting í viðkomandi skjáborðsumhverfi gengur fyrir sig.

Mappan RPMS (eða DEBS) inniheldur einnig pakka sem kallast libreoffice24.2-freedesktop-menus-24.2.0.1-1.noarch.rpm (eða libreoffice24.2-debian-menus_24.2.0.1-1_all.deb, eða álíka). Þetta er uppsetningarpakki fyrir allar þær Linux dreifingar sem styðja Freedesktop.org skilgreiningar/staðla (https://en.wikipedia.org/wiki/Freedesktop.org), og er þessi pakki notaður til uppsetningar á þeim Linux dreifingum sem ekki er minnst á í leiðbeiningunum hér að ofan.

Uppsetning tungumálapakka
----------------------------------------------------------------------

Náðu í tungumálapakkann sem tilheyrir tungumálinu og stýrikerfinu þínu. Þessir pakkar eru tiltækir á sama niðurhalssvæði og aðaluppsetningarskrain. Með Nautilus skráastjóranum geturðu afþjappað safnskrárpakkanum (sem þú náðir í) í einhverja möppu (til dæmis á skjáborðið). Gakktu úr skugga um að þú sért búin/n að loka öllum forritum sem tengjast LibreOffice (þar með talið flýtiræsingunni, QuickStarter).

Skiptu um staðsetningu yfir í möppuna þar sem þú afþjappaðir tungumálapakkanum.

Skiptu núna yfir í möppuna sem búin var til við afþjöppunina. Til dæmis, fyrir íslenskan tungumálapakka fyrir 32-bita stýrikerfi sem byggt er á Debian/Ubuntu, væri heiti möppunnar LibreOffice, plús upplýsingar um útgáfu, plús Linux_x86_langpack-deb_is.

Skiptu síðan yfir í möppuna sem inniheldur sjálfa uppsetningarpakkana. Á kerfum sem byggð eru á Debian/Ubuntu kallast sú mappa "DEBS". Á kerfum sem byggjast á Fedora, Suse eða Mandriva heitir þessi mappa "RPMS".

Í Nautilus skráastjóranum getur þú hægrismellt innan í möppunni og valið "Opna í skjáhermi". Skjáhermir getur einnig veriðkallaður "Útstöð" eða "Skel". Í glugganum sem opnast er svokölluð skipanalína, á hana skrifarðu eftirfarandi skipun (þú verður spurð/ur um rótarlykilorðið áður en skipunin er framkvæmd):

Á kerfum sem byggjast á Debian/Ubuntu: sudo dpkg -i *.deb

Á kerfum sem byggjast á Fedora: su -c 'dnf install *.rpm'

Á kerfum sem byggjast á Mandriva: sudo urpmi *.rpm

Á kerfum sem byggjast á RPM pakkakerfinu (OpenSUSE, o.s.frv.): rpm -Uvh *.rpm

Now start one of the LibreOffice applications - Writer, for instance. Go to the Tools menu and choose Options. In the Options dialog box, click on "Languages and Locales" and then click on "General". Dropdown the "User interface" list and select the language you just installed. If you want, do the same thing for the "Locale setting", the "Default currency", and the "Default languages for documents".

Eftir að hafa stillt þetta, smelltu á "Í lagi". Stillingaglugginn mun lokast og þú færð að sjá skilaboð um að breytingarnar þínar verði ekki virkar eftir að þú hefur lokað öllum LibreOffice forritum og ræst síðpan aftur (muna að loka líka flýtiræsingunni QuickStarter ef hún er í gangi).

Næst þegar þú ræsir LibreOffice mun viðmót þess vera á tungumálinu sem þú varst að setja upp.

----------------------------------------------------------------------
Vandamál við ræsingu forrits
----------------------------------------------------------------------

Erfiðleikar við að ræsa LibreOffice (t.d. forritin frjósa) auk vandamála í sambandi við birtingu á skjá er oft af völdum rekla fyrir skjákort. Ef slík vandamál koma upp, skaltu uppfæra rekilinn fyrir skjákortið þitt eða prófa að nota skjákortsrekilinn sem kom með stýrikerfinu þínu.

----------------------------------------------------------------------
ALPS/Synaptics fartölvu-snertispjöld (touchpad) í Windows
----------------------------------------------------------------------

Vegna galla í Windows rekli, getuðu ekki skrunað í gegnum LibreOffice skjöl með því að renna fingrinum eftir ALPS/Synaptics snertispjöldum (touchpad).

Til að virkja skrun á Touchpad snertispjaldi, bættu þá við eftirfarandi línum í "C:\Program Files\Synaptics\SynTP\SynTPEnh.ini" stillingaskrána, og endurræstu síðan tölvuna:

[LibreOffice]

FC = "SALFRAME"

SF = 0x10000000

SF |= 0x00004000

Staðsetning stillingaskrárinnar gæti verið eitthvað breytileg eftir því um hvaða útgáfu Windows er að ræða.

----------------------------------------------------------------------
Flýtilyklar
----------------------------------------------------------------------

Einungis flýtilyklar (lyklasamsetningar) sem ekki eru í notkun af stýrikerfinu geta verið notaðir í LibreOffice. Ef lyklasamsetning í LibreOffice virkar ekki eins og lýst er í LibreOffice hjálpinni, athugaðu hvort sá flýtilykill sé þegar í notkun af stýrikerfinu. Til að laga slíka árekstra er venjulega hægt að breyta þeim lyklum sem stýrikerfið notar. Hitt er líka mögulegt, þú getur breytt næstum öllum lyklasamsetningum í LibreOffice. Til að skoða nánari upplýsingar um þetta er best að lesa LibreOffice hjálpina eða hjálparskjöl stýrikerfisins.

----------------------------------------------------------------------
Vandamál við að senda skjöl sem tölvupóst úr LibreOffice
----------------------------------------------------------------------

When sending a document via 'File - Send - Email Document' or 'File - Send - Email as PDF' problems might occur (program crashes or hangs). This is due to the Windows system file "Mapi" (Messaging Application Programming Interface) which causes problems in some file versions. Unfortunately, the problem cannot be narrowed down to a certain version number. For more information visit https://www.microsoft.com to search the Microsoft Knowledge Base for "mapi dll".

----------------------------------------------------------------------
Mikilvægar athugasemdir varðandi aðgangsmál
----------------------------------------------------------------------

Fyrir upplýsingar um aðgengismál í LibreOffice, skoðaðu https://www.libreoffice.org/accessibility/

----------------------------------------------------------------------
Stuðningur notenda
----------------------------------------------------------------------

Aðal stuðningssíðan býður upp á margvíslega hjálp varðandi LibreOffice. Hugsanlegt er að spurningunni þinni hafi þegar verið svarað - skoðaðu það á samfélagssvæðinu (Community Forum): https://www.documentfoundation.org/nabble/ eða skoðaðu póstlistayfirlitin fyrir 'users@libreoffice.org' póstlistann hérna: https://www.libreoffice.org/lists/users/. . Einnig gætirðu sent in spurningar á users@libreoffice.org. Ef þú hefur áhuga geturðu gerst áskrifandi að póstlistanum (færð svör í tölvupósti) sendu þá auðan póst á: users+subscribe@libreoffice.org.

Skoðaðu líka algengar spurningar (FAQ) á vefsvæði LibreOffice.

----------------------------------------------------------------------
Tilkynna villur og vandamál
----------------------------------------------------------------------

Kerfið sem við notum fyrir villuskýrslur, eftirfylgni og lausn á göllum er þessa stundina BugZilla, sem er hýst hjá https://bugs.documentfoundation.org/. Við hvetjum alla notendur til að finnast þeir velkomnir við að tilkynna um hverskyns villur og galla sem fundist gætu við notkun. Virkt flæði tilkynninga um það sem betur mætti fara er eitt mikilvægasta framlagið sem notendur geta gefið af sér til áframhaldandi þróunar og bætingar á LibreOffice hugbúnaðinum.

----------------------------------------------------------------------
Taka þátt
----------------------------------------------------------------------

LibreOffice samfélagið myndi hafa mikinn hag af virkri þátttöku þinni í þróun þessa mikilvæga opna hugbúnaðarverkefnis.

Sem notandi ertu nú þegar orðin/n mikilvægur hluti í þróunarferli hugbúnaðarins, við viljum hvetja þig til að taka enn virkari þátt í samfélaginu Endilega skráðu þig og skoðaðu vefsvæði LibreOffice þar sem fram kemur hvernig þú getur komið að enn meira gagni.

Leiðir til að byrja
----------------------------------------------------------------------

Besta leiðin til að taka þátt er að gerast áskrifandi að einum eða fleiri póstlistum, fylgjast með því sem fram fer um stund auk þess að fletta í eldri pósti til að kynnast því sem áður hefur farið fram á listunum síðan grunnkóðiLibreOffice var gefinn frjáls í október árið 2000 Þegar þér finnst tími til kominn, er gott að senda fyrst dálítinn kynningarpóst um sjálfa/n.þig og hoppa síðan í djúpu laugina Ef þú ert þegar búin/n að kynna þér út á hvað opinn og frjáls hugbúnaður gengur (Open Source Projects), skoðaðu þá verkefnalista LibreOffice (To-Dos) og athugaðu hvort þar er eitthvað sem þú gætir hjálpað til við að framkvæma.

Gerast áskrifandi
----------------------------------------------------------------------

Hér eru nokkrir af póstlistum verkefnisins sem þú getur gerst áskrifandi að á https://www.libreoffice.org/get-help/mailing-lists/

* Fréttir: announce@documentfoundation.org *mælt með þessu fyrir alla notendur* (lítil umferð)
* Aðalpóstlisti fyrir notendur: users@global.libreoffice.org *góð leið til að hlera umræður* (mikil umferð)
* Markaðssetning: marketing@global.libreoffice.org *kynningarmál og margt fleira* (umferð að aukast)
* Almennur listi fyrir hugbúnaðarþróun: libreoffice@lists.freedesktop.org (mikil umferð)

Taka þátt í einu eða fleiri verkefnum
----------------------------------------------------------------------

Þú getur gert heilmargt fyrir þetta mikilvæga opna hugbúnaðarverkefni jafnvel þó þú sért ekki með neina reynslu af forritun eða hugbúnaðarhönnun. Já, þú getur verið með!

Við vonumst til að þú njótir þess að vinna með nýja LibreOffice 24.2 og munir ganga til liðs við okkur á netinu.

LibreOffice samfélagið

----------------------------------------------------------------------
Notaður / breyttur grunnkóði
----------------------------------------------------------------------

Höfundarréttur að hluta til: 1998, 1999 James Clark. Höfundarréttur að hluta til: 1996, 1998 Netscape Communications Corporation.
