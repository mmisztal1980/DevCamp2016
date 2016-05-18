![alt](http://devcamp.pl/wp-content/uploads/2016/02/devcamp_logo.png)

# Konfiguracja środowiska

Poniższa instrukcja zakłada, że zespół będzie korzystał z .NET.

W razie problemów z konfiguracją MS Azure, TeamCity lub Cake'a, __w każdej chwili można podejść do Maćka__ i poprosić o pomoc.

## 0. Fork

- Należy utworzyć fork'a tego repozytorium

## 1. Aktywacja Azure Pass

- Każdy zespół otrzyma od organizatorów kod, aktywujący subskrypcję MS Azure, o wartości 100USD.
- Każdy zespół wchodzi na stronę www.outlook.com i rejestruje jedno **__nowe konto liveId__**.
- Każdy zespoł aktywuje subksrypcję MS Azure pod adresem: https://www.microsoftazurepass.com/ używając nowo utworzonego liveId oraz otrzymanego kodu dostępowego.

## 2. Utworzenie Azure App Service

- Każdy zespół loguje za pomocą swojego liveId pod adresem: https://portal.azure.com/
- Po zalogowaniu, należy utworzyć nową aplikację "App Service"

![alt](http://s32.postimg.org/n4z4b4xmt/App_Service01.png)

- Skonfiguruj aplikację:

![alt](http://s32.postimg.org/sec3w5551/App_Service02.png)

- Zakończ wstępną konfigurację aplikacji za pomocą "Create"

![alt](http://s32.postimg.org/4qqh06tl1/App_Service03.png)

## 3. Konfiguracja FTP
Po utworzeniu AppService, należy skonfigurować konto FTP do Continous Deployment.

- Należy wybrać utworzoną aplikację z listy i znaleźć panel "Deployment Credentials"

![alt](http://s32.postimg.org/s2nckxi6d/Ftp01.png)

- Należy skonfigurować dostęp dla użytkownika FTP.

![alt](http://s32.postimg.org/be58y9phh/Ftp02.png)

- Po konfiguracji należy zapisać: FTP hostname, pełną nazwę użytkownika i hasło.

![alt](http://s32.postimg.org/qi5nqywxx/Ftp03.png)

- Mając te informacje, można skonfigurować Continous Deployment za pomocą TeamCity.
- Należy udać się do osób zarządzających TeamCity aby skonfigurować automatyczny build swojego projektu.

## 4. Konfiguracja automatycznego build'u projektu:

- Należy otworzyć plik ```build.cake``` do edycji
- Należy zmienić wartość ```project.WebAppName``` na wartość odpowiadającą nazwie aplikacji ASP.NET, która będzie automatycznie deploy'owana do Azure

![alt](http://s32.postimg.org/5jm75g4n9/Cake01.png)

- Build można przetestować z linii poleceń, za pomocą : ```build.cmd -taget=Deploy -configuration=Release```
