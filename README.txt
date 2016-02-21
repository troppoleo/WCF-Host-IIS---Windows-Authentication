Il WCF è configurato per windows authentication e ha un solo metodo che restituisce chi è il chiamante 

mySB.AppendLine(string.Format("Is authenticated: {0}", ServiceSecurityContext.Current.PrimaryIdentity.IsAuthenticated));
mySB.AppendLine(string.Format("Authentication Type: {0}", ServiceSecurityContext.Current.PrimaryIdentity.AuthenticationType));
mySB.AppendLine(string.Format("Authentication Name: {0}", ServiceSecurityContext.Current.PrimaryIdentity.Name));


ed è pubblicato su IIS configurato con Windows authentication e diabilitando l'anonimo

il Client è una winwdows application semplice a cui ho referenziato la pagina web dell'iis e richiama
il suo metodo
