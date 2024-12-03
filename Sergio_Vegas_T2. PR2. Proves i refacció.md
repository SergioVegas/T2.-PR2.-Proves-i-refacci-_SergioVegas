# Exercici 1

**Quines són les característiques i els escenaris d'ús de les metodologies àgils de desenvolupament de programari? Explica amb detall i posa un exemple.**


**Individus i interaccions** per sobre de processos i eines.\
**Programari que funciona** per sobre de documentació exhaustiva.\
**Col·laboració amb el client** per sobre de negociació de contractes.\
**Resposta al canvi** per sobre de cenyir-se a una planificació.\

La metodologia àgil parla sobre com s’han de prioritzar certes coses en situacions concretas, en els exemples de d’alt les paraules en negreta son la prioritat. Això no vol dir que la resta no sigui important, però hem de saber prioritzar.\
 En conclusió hem de donar preferència a certes coses en els projectes. Per exemple: Quan volem modificar parts importants del projecte, intentar tindre tota la comunicació cara a cara, prioritzar que el programa funcioni amb els canvis i sigui el més eficient i simple possible, treballant en equip i sempre mantenir una comunicació constant en tot el projecte.

# Exercici 2

**Què són els dobles de prova? Explica amb detall els diferents tipus i posa un exemple d’ús per a una solució en C#.**


Son eines que s’utilitzen a l’hora de programar, en particular en testing software per simular certes interaccions(normalment quan necessitem una variable ) en un entorn de proves.\
**Dummy**: Son utilitzats per proporcionar una implementació buida  per a la dependencia necessària en el nostre codi. \
**Stub**: Utilitzen per simular el comportament d’una dependencia. Proporcionen respostes predefinides a certes entrades i s'utilitzen per comprovar com actua el programa en diferents casos. \
**Fake**: imitan el comportament i la interfaz d’una dependencia real, pero utilitcen una implementació simplificada i més senzilla de probar.  
**Spy**:  Registran el comportament d’una dependència durant una prova per poder verificar el seu funcionament.\
**Mock**: Verifiquen el comportament d’una dependència durant una prova, controlant cada interacció. Son bàsicament l’evolució dels spy.

# Exercici 4
He fet unit test a les dues funcions que donen algun resultat i tenen calculs dins. He fet una per quan els casos eren els esperats i quan no ho eren.\
He tingut problemes fent els UnitTest, com pots veure a l'imatge no em carrega els units test i ademés els nous que he fet no m'els agafa tot i fer-ho de la mateixa forma.
![ErrorUnitTest](/Imatges/ErrorUniTest.png)
# Exercici 5
En aquest cas he decidit fer UnitTest per tots el casos possibles, incluint els defaults.\
En la funcio de classifyAge he fet els valors limits del rang per l'edat adulta.\
També he tingut porblemes mab el visualStudio al fer els UnitTest. Directament no m'agafa el archiu dll, tot i agregar-lo bé com es  veure a l'imatge.
![ErrorDll](/Imatges/Errordll.png)
# Exercici 7
**Indica les referències que has consultat (pàgines web, llibres, revistes,...), seguint el següent format:**

https://ca.wikipedia.org/wiki/Metodologia_%C3%A0gil [Autor anonim, 01/12/2024] [Metodologia àgil]\
https://agilemanifesto.org/iso/ca/manifesto.html [Més d’un autor(estan a la pagina web, 01/12/2024], [Manifest per al desenvolupament àgil de programari]\
https://devexpert.io/dobles-test/ [Antonio Leiva, , 01/12/2024], [¿Qué son los dobles de test?]\
https://unity.com/es/topics/what-is-ci-cd [Autor anonim,02/12/2024], [¿Qué es CI/CD?]\
https://about.gitlab.com/es/topics/ci-cd/ [Autor anonim,02/12/2024], [¿Qué es CI/CD?]\
https://sentrio.io/blog/que-es-sonarqube/ [Sentrio,02/12/2024], [Qué es SonarQube: Verifica y analiza la calidad de tu código]\
https://go4it.solutions/es/blog/que-es-el-analisis-de-codigo-estatico [Goat4IT Solutions, 02/12/2024], [¿Qué es el análisis de código estático?]\
https://learn.microsoft.com/es-es/dotnet/core/testing/unit-testing-with-dotnet-test [25 authors, 03/12/2024], [Prueba unitaria de C# en .NET mediante pruebas de dotnet y xUnit]