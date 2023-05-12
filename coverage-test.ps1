md D:\a\_work\1\s
cd D:\a\_work\1\s
git clone --no-checkout --filter=tree:0 https://github.com/Azure/azure-sdk-for-net .
git sparse-checkout init
git sparse-checkout set --no-cone '/*' '!/*/' '/eng'
git sparse-checkout add '/*' '!SessionRecords' '/sdk/storage/**/SessionRecords/*'
git -c advice.detachedHead=false checkout 5ceb917fa30e79e8b8084ad7ff700d0ed2ccf134

# install azurerite
npm install --prefix artifacts/storage/azurite azurite@3.11.0
${Env:Azure_Azurite_Location} = (Resolve-Path .\artifacts\storage\azurite\)

# test with coverage
dotnet test eng/service.proj --filter "(TestCategory!=Manually) & (TestCategory!=Live) & (Placeholder!=DefaultIgnoreMe)" --framework net7.0 --logger "trx;LogFileName=net7.0.trx" --logger:"console;verbosity=normal" --blame-crash-dump-type full --blame-hang-dump-type full --blame-hang-timeout 60minutes /p:SDKType=all /p:ServiceDirectory=storage /p:IncludeSrc=false /p:IncludeSamples=false /p:IncludePerf=false /p:IncludeStress=false /p:RunApiCompat=false /p:InheritDocEnabled=false /p:Configuration=Debug /p:CollectCoverage=true /p:EnableSourceLink=false /p:ProjectListOverrideFile=