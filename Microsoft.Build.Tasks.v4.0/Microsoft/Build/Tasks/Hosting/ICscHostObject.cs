﻿namespace Microsoft.Build.Tasks.Hosting
{
    using Microsoft.Build.Framework;
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("8520CC4D-64DC-4855-BE3F-4C28CCE048EE")]
    public interface ICscHostObject : ITaskHost
    {
        bool IsDesignTime();
        bool Compile();
        void BeginInitialization();
        bool EndInitialization(out string errorMessage, out int errorCode);
        bool SetAdditionalLibPaths(string[] additionalLibPaths);
        bool SetAddModules(string[] addModules);
        bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks);
        bool SetBaseAddress(string baseAddress);
        bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow);
        bool SetCodePage(int codePage);
        bool SetDebugType(string debugType);
        bool SetDefineConstants(string defineConstants);
        bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign);
        bool SetDisabledWarnings(string disabledWarnings);
        bool SetDocumentationFile(string documentationFile);
        bool SetEmitDebugInformation(bool emitDebugInformation);
        bool SetErrorReport(string errorReport);
        bool SetFileAlignment(int fileAlignment);
        bool SetGenerateFullPaths(bool generateFullPaths);
        bool SetKeyContainer(string keyContainer);
        bool SetKeyFile(string keyFile);
        bool SetLangVersion(string langVersion);
        bool SetLinkResources(ITaskItem[] linkResources);
        bool SetMainEntryPoint(string targetType, string mainEntryPoint);
        bool SetModuleAssemblyName(string moduleAssemblyName);
        bool SetNoConfig(bool noConfig);
        bool SetNoStandardLib(bool noStandardLib);
        bool SetOptimize(bool optimize);
        bool SetOutputAssembly(string outputAssembly);
        bool SetPlatform(string platform);
        bool SetPdbFile(string pdbFile);
        bool SetReferences(ITaskItem[] references);
        bool SetResources(ITaskItem[] resources);
        bool SetResponseFiles(ITaskItem[] responseFiles);
        bool SetSources(ITaskItem[] sources);
        bool SetTargetType(string targetType);
        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
        bool SetWarningLevel(int warningLevel);
        bool SetWarningsAsErrors(string warningsAsErrors);
        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
        bool SetWin32Icon(string win32Icon);
        bool SetWin32Resource(string win32Resource);
        bool IsUpToDate();
    }
}

