@echo off

echo 1. Stop Nginx Service
net stop nnp_nginx
echo.

echo 2. Stop Naive Service
net stop nnp_naive
echo.

echo 3. Delete Nginx Service
sc delete nnp_nginx
echo. 

echo 4. Delete Naive Service
sc delete nnp_naive
echo.

echo 5. Delete Service Config
DEL /Q /F /S naive\naive-service.xml 
DEL /Q /F /S naive\logs
DEL /Q /F /S nginx\nginx-service.xml
DEL /Q /F /S nginx\logs
DEL /Q /F /S naive.ini
rd /s /q naive
rd /s /q nginx
echo.
exit