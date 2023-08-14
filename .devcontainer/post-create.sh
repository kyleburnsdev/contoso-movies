# install relevant az cli extensions
extensions=(account alias deploy-to-azure functionapp subscription webapp)
for extension in $extensions;
do
    az extension add --name $extension
done

az bicep install

npm i -g azure-functions-core-tools@4 --unsafe-perm true
