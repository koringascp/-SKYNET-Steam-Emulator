﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKYNET.Interface
{
    public interface ISteamMatchmakingServers
    {
        // Request a new list of servers of a particular type.  These calls each correspond to one of the EMatchMakingType values.
        // Each call allocates a new asynchronous request object.
        // Request object must be released by calling ReleaseRequest( IntPtr )
        IntPtr RequestInternetServerList(IntPtr iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);
        IntPtr RequestLANServerList(IntPtr iApp, IntPtr pRequestServersResponse);
        IntPtr RequestFriendsServerList(IntPtr iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);
        IntPtr RequestFavoritesServerList(IntPtr iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);
        IntPtr RequestHistoryServerList(IntPtr iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);
        IntPtr RequestSpectatorServerList(IntPtr iApp, IntPtr ppchFilters, uint nFilters, IntPtr pRequestServersResponse);

        // Releases the asynchronous request object and cancels any pending query on it if there's a pending query in progress.
        // RefreshComplete callback is not posted when request is released.
        void ReleaseRequest(IntPtr hServerListRequest);

        /* the filter operation codes that go in the key part of IntPtr should be one of these:

            "map"
                - Server passes the filter if the server is playing the specified map.
            "gamedataand"
                - Server passes the filter if the server's game data (ISteamGameServer::SetGameData) contains all of the
                specified strings.  The value field is a comma-delimited list of strings to match.
            "gamedataor"
                - Server passes the filter if the server's game data (ISteamGameServer::SetGameData) contains at least one of the
                specified strings.  The value field is a comma-delimited list of strings to match.
            "gamedatanor"
                - Server passes the filter if the server's game data (ISteamGameServer::SetGameData) does not contain any
                of the specified strings.  The value field is a comma-delimited list of strings to check.
            "gametagsand"
                - Server passes the filter if the server's game tags (ISteamGameServer::SetGameTags) contains all
                of the specified strings.  The value field is a comma-delimited list of strings to check.
            "gametagsnor"
                - Server passes the filter if the server's game tags (ISteamGameServer::SetGameTags) does not contain any
                of the specified strings.  The value field is a comma-delimited list of strings to check.
            "and" (x1 && x2 && ... && xn)
            "or" (x1 || x2 || ... || xn)
            "nand" !(x1 && x2 && ... && xn)
            "nor" !(x1 || x2 || ... || xn)
                - Performs Boolean operation on the following filters.  The operand to this filter specifies
                the "size" of the Boolean inputs to the operation, in Key/value pairs.  (The keyvalue
                pairs must immediately follow, i.e. this is a prefix logical operator notation.)
                In the simplest case where Boolean expressions are not nested, this is simply
                the number of operands.

                For example, to match servers on a particular map or with a particular tag, would would
                use these filters.

                    ( server.map == "cp_dustbowl" || server.gametags.contains("payload") )
                    "or", "2"
                    "map", "cp_dustbowl"
                    "gametagsand", "payload"

                If logical inputs are nested, then the operand specifies the size of the entire
                "length" of its operands, not the number of immediate children.

                    ( server.map == "cp_dustbowl" || ( server.gametags.contains("payload") && !server.gametags.contains("payloadrace") ) )
                    "or", "4"
                    "map", "cp_dustbowl"
                    "and", "2"
                    "gametagsand", "payload"
                    "gametagsnor", "payloadrace"

                Unary NOT can be achieved using either "nand" or "nor" with a single operand.

            "addr"
                - Server passes the filter if the server's query address matches the specified IP or IP:port.
            "gameaddr"
                - Server passes the filter if the server's game address matches the specified IP or IP:port.

            The following filter operations ignore the "value" part of IntPtr

            "dedicated"
                - Server passes the filter if it passed true to SetDedicatedServer.
            "secure"
                - Server passes the filter if the server is VAC-enabled.
            "notfull"
                - Server passes the filter if the player count is less than the reported max player count.
            "hasplayers"
                - Server passes the filter if the player count is greater than zero.
            "noplayers"
                - Server passes the filter if it doesn't have any players.
            "linux"
                - Server passes the filter if it's a linux server
        */

        // Get details on a given server in the list, you can get the valid range of index
        // values by calling GetServerCount().  You will also receive index values in 
        // IntPtr::ServerResponded() callbacks
        IntPtr GetServerDetails(IntPtr hRequest, int iServer);

        // Cancel an request which is operation on the given list type.  You should call this to cancel
        // any in-progress requests before destructing a callback object that may have been passed 
        // to one of the above list request calls.  Not doing so may result in a crash when a callback
        // occurs on the destructed object.
        // Canceling a query does not release the allocated request handle.
        // The request handle must be released using ReleaseRequest( hRequest )
        void CancelQuery(IntPtr hRequest);

        // Ping every server in your list again but don't update the list of servers
        // Query callback installed when the server list was requested will be used
        // again to post notifications and RefreshComplete, so the callback must remain
        // valid until another RefreshComplete is called on it or the request
        // is released with ReleaseRequest( hRequest )
        void RefreshQuery(IntPtr hRequest);

        // Returns true if the list is currently refreshing its server list
        bool IsRefreshing(IntPtr hRequest);

        // How many servers in the given list, GetServerDetails above takes 0... GetServerCount() - 1
        int GetServerCount(IntPtr hRequest);

        // Refresh a single server inside of a query (rather than all the servers )
        void RefreshServer(IntPtr hRequest, int iServer);


        //-----------------------------------------------------------------------------
        // Queries to individual servers directly via IP/Port
        //-----------------------------------------------------------------------------

        // Request updated ping time and other details from a single server
        uint PingServer(uint unIP, uint usPort, IntPtr pRequestServersResponse);

        // Request the list of players currently playing on a server
        uint PlayerDetails(uint unIP, uint usPort, IntPtr pRequestServersResponse);

        // Request the list of rules that the server is running (See ISteamGameServer::SetKeyValue() to set the rules server side)
        uint ServerRules(uint unIP, uint usPort, IntPtr pRequestServersResponse);

        // Cancel an outstanding Ping/Players/Rules query from above.  You should call this to cancel
        // any in-progress requests before destructing a callback object that may have been passed 
        // to one of the above calls to avoid crashing when callbacks occur.
        void CancelServerQuery(uint hServerQuery);
    }
}
