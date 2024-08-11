# RCCKillerService

![Static Badge](https://img.shields.io/badge/erLCoder-RCCKillerService-RCCKillerService)
![GitHub top language](https://img.shields.io/github/languages/top/erLCoder/RCCKillerService)
![GitHub License](https://img.shields.io/github/license/erLCoder/RCCKillerService)
![GitHub Repo stars](https://img.shields.io/github/stars/erLCoder/RCCKillerService)
![GitHub Issues or Pull Requests](https://img.shields.io/github/issues/erLCoder/RCCKillerService)

## Описание

RCCKillerService - это служба Windows, написанная на C#, предназначенная для автоматического завершения процессов, связанных с определенными приложениями, которые используются во время проверок в игре Rust. Эта служба полезна для читеров, которые хотят усложнить проверку их ПК на вспомогательное ПО.

## Функции

- Автоматическое завершение процессов по заданному списку(RustCheatCheck.exe и osk.exe).
- Логирование действий службы.

## Установка

### Требования

- Windows 7 или выше.
- .NET Framework 4.5 или выше.

### Шаги по установке релиз версии

1. **Скачайте релизную версию:**

   Перейдите на страницу [релизов](https://github.com/erLCOder/RCCKillerService/releases) вашего репозитория на GitHub и скачайте последнюю стабильную версию.

2. **Распакуйте архив:**

   Распакуйте ZIP архив в удобное для вас место

3. **Откройте установщик RCCKillerService:**

   Запустите установщик ```RCCInstaller.msi``` от имени администратора. После установки служба автоматически начинает свою работу

### Шаги по сборке

1. **Склонируйте репозиторий:**
   ```bash
   git clone https://github.com/erLCoder/RCCKillerService.git
   ```

2. **Соберите проект:** Откройте решение в Visual Studio и соберите проект. Убедитесь, что сборка прошла успешно.
   
3. **Установите службу с помощью InstallUtil.exe:** Откройте командную строку с правами администратора и выполните следующие команды:
   ```bash
   cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319
   InstallUtil.exe путь_к_папке_с_ProcMonitor.exe
   ```
4. **Запустите службу:** После установки службы вы можете запустить ее через ```services.msc``` название службы "Служба мониторинга процессов"

## Использование
После запуска службы она будет работать в фоновом режим и автоматически завершать процессы. Логи действий записываются в ```eventvwr.msc``` ---> "Журналы Windows" ---> "Приложение". Что позволит вам отслеживать работу службы.

## Удаление службы
Если вам нужно удалить службу, выполните 3 шаг из "Установка", но используя другой промпт
```bash
cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319
InstallUtil.exe /u путь_к_папке_с_ProcMonitor.exe
```

## Вклад
Если вы хотите внести свой вклад в проект, пожалуйста, создайте форк репозитория, внесите изменения и отправьте пулл-реквест.

## Лицензия
Этот проект лицензирован под MIT License. Подробности смотрите в файле [LICENSE](LICENSE).
