## �x�W������H�� REST API �ʸ�

[![Build status](https://ci.appveyor.com/api/projects/status/d5viju19wmj3tff6/branch/master?svg=true)](https://ci.appveyor.com/project/0x0001F36D/opendata-cwb-gov-tw/branch/master)
## ���[
�S�ݨ�H�gC#�������ʸˡA��O�ڴN��F�@�Ǯɶ��g�F�o�ӡC�p�G�����~�άO�A����n���g�k�APR�j�O��N��F!!!�ڬݧ��S���D�N�|�X�֤F�C

## �о�
1. ���n�J [��H��ƶ}�񥭥x](https://opendata.cwb.gov.tw)
2. ���U [����](https://opendata.cwb.gov.tw/devManual/insrtuction#getUserAuthkeyAnchor) ���� ![���o���v�X](./img/getAuthCode.png) ���o�k�誺���v�X�ýƻs
3. �ƻs�U�誺�{���X
```csharp
using Opendata.Core;
```
```csharp
// �إ߳s�u����
var client = new OpendataClient(apikey: "�A�����v�X");
// �b QueryBy �R�A���O���̷ӧA�һݭn�� dataId ��X�������d�ߪ���A�H F-C0032-001(�@��Ѯ�w��-���� 36 �p�ɤѮ�w��) ����
var subject = QueryBy.F_C0032_001; 
// ���^ Records, �A�n����Ƴ��b�̭�
var records = client.GetAsync(queryBy: subject).Result;
```

## ����
 - 1.0.0
 
## �w��
 > �w�ˤw�g�o��� [nuget.org](https://nuget.org)�A�b�M��޲z�����j�M **Opendata.Core** �Y�i
 - �ϥ� Package Manager
    ```
    Install-Package Opendata.Core -Version 1.0.0
    ```

## �Ѧ�
[������H���}���ƥ��O������^��API](https://opendata.cwb.gov.tw/dist/opendata-swagger.html)

## �ĤT��M��
[Json.Net](https://www.newtonsoft.com/)

## ���v
[MIT License](./.license)