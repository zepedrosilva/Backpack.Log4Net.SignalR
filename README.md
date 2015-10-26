# Backpack.Log4Net.SignalR

Backpack.Log4Net.SignalR is a simple log4net signalR appender.

[![Build status](https://ci.appveyor.com/api/projects/status/ithh8t2ws1bbrq7l/branch/master)](https://ci.appveyor.com/project/JoseSilva/backpack-log4net-signalr/branch/master)

## Usage

### Step 1: Add the Backpack.Log4Net.SignalR nuget package

```
install-package Backpack.Log4Net.SignalR
```

### Step 2: Configure the signalr appender

```
<?xml version="1.0"?>
<configuration>

    <configSections>
        <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
    </configSections>

    <log4net>
        <appender name="SignalrAppender" type="Backpack.Log4Net.SignalR.SignalrAppender, Backpack.Log4Net.SignalR">
            <layout type="log4net.Layout.PatternLayout">
                <conversionPattern value="%date %-5level: %message%newline" />
            </layout>
        </appender>
        <root>
            <level value="ALL" />
            <appender-ref ref="SignalrAppender" />
        </root>
    </log4net>

</configuration>
```
  
## License

The MIT License (MIT)
Copyright (c) 2015 Jose Silva

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANT ABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.