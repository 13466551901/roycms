@echo off

echo - ���ݵ���һ��Ŀ¼ �����ĵȴ� / Copying Web Files ...

set date0=%date:~0,10%

xcopy  *.* G:\�汾\%date0%\ /s /y /q

