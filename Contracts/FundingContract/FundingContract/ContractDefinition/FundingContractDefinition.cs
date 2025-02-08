using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace FundingContract.FundingContract.ContractDefinition
{


    public partial class FundingContractDeployment : FundingContractDeploymentBase
    {
        public FundingContractDeployment() : base(BYTECODE) { }
        public FundingContractDeployment(string byteCode) : base(byteCode) { }
    }

    public class FundingContractDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b50600180546001600160a01b0319163390811790915561003290600090610061565b61005c7fa49807205ce4d355092ef5a8a18f56e8913cf4a201fbe287825b095693c2177533610061565b610100565b6000828152602081815260408083206001600160a01b038516845290915290205460ff166100fc576000828152602081815260408083206001600160a01b03851684529091529020805460ff191660011790556100bb3390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45b5050565b6109fa8061010f6000396000f3fe6080604052600436106100ab5760003560e01c806336568abe1161006457806336568abe146102105780633ccfd60b14610230578063497c076b1461024557806391d1485414610279578063a217fddf14610299578063d547741f146102ae57600080fd5b806301ffc9a7146100e4578063136d6a3914610119578063248a9ca31461015d57806327e235e31461018d5780632a0acc6a146101ba5780632f2ff15d146101ee57600080fd5b366100df57336000908152600260205260409020546100cb9034906107e5565b336000908152600260205260409020819055005b600080fd5b3480156100f057600080fd5b506101046100ff3660046107f8565b6102ce565b60405190151581526020015b60405180910390f35b34801561012557600080fd5b5061014f61013436600461083e565b6001600160a01b031660009081526002602052604090205490565b604051908152602001610110565b34801561016957600080fd5b5061014f610178366004610859565b60009081526020819052604090206001015490565b34801561019957600080fd5b5061014f6101a836600461083e565b60026020526000908152604090205481565b3480156101c657600080fd5b5061014f7fa49807205ce4d355092ef5a8a18f56e8913cf4a201fbe287825b095693c2177581565b3480156101fa57600080fd5b5061020e610209366004610872565b610305565b005b34801561021c57600080fd5b5061020e61022b366004610872565b61032f565b34801561023c57600080fd5b5061020e6103b2565b34801561025157600080fd5b5061014f7f7075bbebc460716132af5a031e5ed67e671ddee73e6c98be8173ea60f9233db881565b34801561028557600080fd5b50610104610294366004610872565b61047d565b3480156102a557600080fd5b5061014f600081565b3480156102ba57600080fd5b5061020e6102c9366004610872565b6104a6565b60006001600160e01b03198216637965db0b60e01b14806102ff57506301ffc9a760e01b6001600160e01b03198316145b92915050565b600082815260208190526040902060010154610320816104cb565b61032a83836104d8565b505050565b6001600160a01b03811633146103a45760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b60648201526084015b60405180910390fd5b6103ae828261055c565b5050565b6103dc7f7075bbebc460716132af5a031e5ed67e671ddee73e6c98be8173ea60f9233db83361047d565b156104295760405162461bcd60e51b815260206004820152601a60248201527f43616c6c6572206973206163746976656c792062696464696e67000000000000604482015260640161039b565b33600081815260026020526040808220549051909291829184156108fc0291859190818181858888f19350505050158015610468573d6000803e3d6000fd5b50503360009081526002602052604081205550565b6000918252602082815260408084206001600160a01b0393909316845291905290205460ff1690565b6000828152602081905260409020600101546104c1816104cb565b61032a838361055c565b6104d581336105c1565b50565b6104e2828261047d565b6103ae576000828152602081815260408083206001600160a01b03851684529091529020805460ff191660011790556105183390565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b610566828261047d565b156103ae576000828152602081815260408083206001600160a01b0385168085529252808320805460ff1916905551339285917ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b9190a45050565b6105cb828261047d565b6103ae576105d88161061a565b6105e383602061062c565b6040516020016105f49291906108c2565b60408051601f198184030181529082905262461bcd60e51b825261039b91600401610937565b60606102ff6001600160a01b03831660145b6060600061063b83600261096a565b6106469060026107e5565b67ffffffffffffffff81111561065e5761065e610981565b6040519080825280601f01601f191660200182016040528015610688576020820181803683370190505b509050600360fc1b816000815181106106a3576106a3610997565b60200101906001600160f81b031916908160001a905350600f60fb1b816001815181106106d2576106d2610997565b60200101906001600160f81b031916908160001a90535060006106f684600261096a565b6107019060016107e5565b90505b6001811115610779576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061073557610735610997565b1a60f81b82828151811061074b5761074b610997565b60200101906001600160f81b031916908160001a90535060049490941c93610772816109ad565b9050610704565b5083156107c85760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e74604482015260640161039b565b9392505050565b634e487b7160e01b600052601160045260246000fd5b808201808211156102ff576102ff6107cf565b60006020828403121561080a57600080fd5b81356001600160e01b0319811681146107c857600080fd5b80356001600160a01b038116811461083957600080fd5b919050565b60006020828403121561085057600080fd5b6107c882610822565b60006020828403121561086b57600080fd5b5035919050565b6000806040838503121561088557600080fd5b8235915061089560208401610822565b90509250929050565b60005b838110156108b95781810151838201526020016108a1565b50506000910152565b7f416363657373436f6e74726f6c3a206163636f756e74200000000000000000008152600083516108fa81601785016020880161089e565b7001034b99036b4b9b9b4b733903937b6329607d1b601791840191820152835161092b81602884016020880161089e565b01602801949350505050565b602081526000825180602084015261095681604085016020870161089e565b601f01601f19169190910160400192915050565b80820281158282048414176102ff576102ff6107cf565b634e487b7160e01b600052604160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b6000816109bc576109bc6107cf565b50600019019056fea2646970667358221220351094b25fe9f7691b3040a1ac109d9e7a3abca9d89e7d63030444494082593b64736f6c63430008130033";
        public FundingContractDeploymentBase() : base(BYTECODE) { }
        public FundingContractDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ACTIVE_BIDDERFunction : ACTIVE_BIDDERFunctionBase { }

    [Function("ACTIVE_BIDDER", "bytes32")]
    public class ACTIVE_BIDDERFunctionBase : FunctionMessage
    {

    }

    public partial class ADMINFunction : ADMINFunctionBase { }

    [Function("ADMIN", "bytes32")]
    public class ADMINFunctionBase : FunctionMessage
    {

    }

    public partial class DEFAULT_ADMIN_ROLEFunction : DEFAULT_ADMIN_ROLEFunctionBase { }

    [Function("DEFAULT_ADMIN_ROLE", "bytes32")]
    public class DEFAULT_ADMIN_ROLEFunctionBase : FunctionMessage
    {

    }

    public partial class BalancesFunction : BalancesFunctionBase { }

    [Function("balances", "uint256")]
    public class BalancesFunctionBase : FunctionMessage
    {
        [Parameter("address", "participant", 1)]
        public virtual string Participant { get; set; }
    }

    public partial class GetBalanceByAddressFunction : GetBalanceByAddressFunctionBase { }

    [Function("getBalanceByAddress", "uint256")]
    public class GetBalanceByAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "balanceAddress", 1)]
        public virtual string BalanceAddress { get; set; }
    }

    public partial class GetRoleAdminFunction : GetRoleAdminFunctionBase { }

    [Function("getRoleAdmin", "bytes32")]
    public class GetRoleAdminFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GrantRoleFunction : GrantRoleFunctionBase { }

    [Function("grantRole")]
    public class GrantRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasRoleFunction : HasRoleFunctionBase { }

    [Function("hasRole", "bool")]
    public class HasRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RenounceRoleFunction : RenounceRoleFunctionBase { }

    [Function("renounceRole")]
    public class RenounceRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RevokeRoleFunction : RevokeRoleFunctionBase { }

    [Function("revokeRole")]
    public class RevokeRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw")]
    public class WithdrawFunctionBase : FunctionMessage
    {

    }

    public partial class RoleAdminChangedEventDTO : RoleAdminChangedEventDTOBase { }

    [Event("RoleAdminChanged")]
    public class RoleAdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("bytes32", "previousAdminRole", 2, true )]
        public virtual byte[] PreviousAdminRole { get; set; }
        [Parameter("bytes32", "newAdminRole", 3, true )]
        public virtual byte[] NewAdminRole { get; set; }
    }

    public partial class RoleGrantedEventDTO : RoleGrantedEventDTOBase { }

    [Event("RoleGranted")]
    public class RoleGrantedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class RoleRevokedEventDTO : RoleRevokedEventDTOBase { }

    [Event("RoleRevoked")]
    public class RoleRevokedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class ACTIVE_BIDDEROutputDTO : ACTIVE_BIDDEROutputDTOBase { }

    [FunctionOutput]
    public class ACTIVE_BIDDEROutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class ADMINOutputDTO : ADMINOutputDTOBase { }

    [FunctionOutput]
    public class ADMINOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class DEFAULT_ADMIN_ROLEOutputDTO : DEFAULT_ADMIN_ROLEOutputDTOBase { }

    [FunctionOutput]
    public class DEFAULT_ADMIN_ROLEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class BalancesOutputDTO : BalancesOutputDTOBase { }

    [FunctionOutput]
    public class BalancesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "depositAmount", 1)]
        public virtual BigInteger DepositAmount { get; set; }
    }

    public partial class GetBalanceByAddressOutputDTO : GetBalanceByAddressOutputDTOBase { }

    [FunctionOutput]
    public class GetBalanceByAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetRoleAdminOutputDTO : GetRoleAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }



    public partial class HasRoleOutputDTO : HasRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }


}
