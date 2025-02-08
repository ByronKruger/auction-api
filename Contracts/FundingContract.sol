// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.19;

import "@openzeppelin/contracts/access/AccessControl.sol";

contract FundingContract is AccessControl {
    address admin;
    bytes32 public constant ADMIN = keccak256("ADMIN_ROLE");
    mapping(address participant => uint depositAmount) public balances; // might need to be decimal
    bytes32 public constant ACTIVE_BIDDER = keccak256("ACTIVE_BIDDER");

    constructor() {
        admin = msg.sender;
        _grantRole(DEFAULT_ADMIN_ROLE, msg.sender);
        _grantRole(ADMIN, msg.sender);
    }

    // fund contract for a bidder
    receive() payable external {
        balances[msg.sender] = balances[msg.sender] + msg.value;
    }

    function withdraw() public { // addresses capable of receiving funds can call it
        require(!hasRole(ACTIVE_BIDDER, msg.sender), "Caller is actively bidding");
        uint256 amount = balances[msg.sender];
        // require(amount > 0, "No contributions to withdraw");
        address payable receiver = payable(msg.sender);
        receiver.transfer(amount);
        balances[msg.sender] = 0;
        // balances[msg.sender] -=...; // + require statement
    }

    // for testing purposes
    function getBalanceByAddress(address balanceAddress) public view returns (uint) {
       return balances[balanceAddress];
    }

}