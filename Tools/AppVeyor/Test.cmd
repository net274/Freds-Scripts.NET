@echo off
call "%vs140comntools%vsvars32.bat"

powershell -ExecutionPolicy Unrestricted ..\Scripts\AppVeyor\Test.ps1