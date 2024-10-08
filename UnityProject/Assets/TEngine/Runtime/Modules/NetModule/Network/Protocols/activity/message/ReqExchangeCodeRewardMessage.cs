using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 领取兑换码奖励请求消息 message
 */
public class ReqExchangeCodeRewardMessage : Message 
{
	//兑换码
	string _exchangeCode;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//兑换码
		SerializeUtils.WriteString(stream, _exchangeCode);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//兑换码
		_exchangeCode = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 兑换码
	 */
	public string ExchangeCode
	{
		set { _exchangeCode = value; }
	    get { return _exchangeCode; }
	}
	
	
	public override int GetId() 
	{
		return 311203;
	}
}