(rules): we can enter data in the form of 0 and 1, where one is a connected server and 0 is a server out of service, 
one server is connected to another if they are still in the same row or column so, we return the total of servers connected 
to others.

(CountServers function): it scans each index of the array with the help of the 2 nested "for"s and if it finds a 1 it calls the
following method.

(Validation function): here it is counted if there are other servers in the same row or column, if there are, they will be added 
to the list to avoid repetitions and if not, they are added

conclusion: at the end we return the size of the list, which would be the connected servers.😸😺
