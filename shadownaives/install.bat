@echo off

echo 1.Create Naive Service Config
set nnp=%cd%
:xml
(
echo ^<?xml version="1.0" encoding="UTF-8" ?^>
echo ^<service^>
echo     ^<id^>nnp_naive^</id^>
echo     ^<name^>nnp_naive^</name^>
echo     ^<description^>Naive Client Service^</description^>
echo     ^<logpath^>%nnp%\naive\logs^</logpath^>
echo     ^<log mode="roll-by-size"^>
echo         ^<sizeThreshold^>10240^</sizeThreshold^>
echo         ^<keepFiles^>8^</keepFiles^>
echo     ^</log^>
echo     ^<executable^>%nnp%\naive\naive.exe^</executable^>
echo     ^<startarguments^>--config %nnp%\naive\config.json^</startarguments^>
echo ^</service^>
)>naive/naive-service.xml
echo.

echo 2.Create Nginx Service Config
:xml
(
echo ^<?xml version="1.0" encoding="UTF-8" ?^>
echo ^<service^>
echo     ^<id^>nnp_nginx^</id^>
echo     ^<name^>nnp_nginx^</name^>
echo     ^<description^>High Performance Nginx Service^</description^>
echo     ^<logpath^>%nnp%\nginx\logs^</logpath^>
echo     ^<log mode="roll-by-size"^>
echo         ^<sizeThreshold^>10240^</sizeThreshold^>
echo         ^<keepFiles^>8^</keepFiles^>
echo     ^</log^>
echo     ^<executable^>%nnp%\nginx\nginx.exe^</executable^>
echo     ^<startarguments^>-p %nnp%\nginx^</startarguments^>
echo     ^<stopexecutable^>%nnp%\nginx\nginx.exe^</stopexecutable^>
echo     ^<stoparguments^>-p %nnp%\nginx -s stop^</stoparguments^>
echo ^</service^>
)>nginx/nginx-service.xml
echo.

cd naive
echo 3. Start Intall Service
naive-service.exe install
echo.

cd ../nginx
echo 4. Start Intall Service
nginx-service.exe install
echo.
exit

