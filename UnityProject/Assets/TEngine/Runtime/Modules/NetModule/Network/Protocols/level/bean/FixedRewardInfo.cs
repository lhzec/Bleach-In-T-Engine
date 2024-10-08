using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 关卡固定奖励信息
 */
public class FixedRewardInfo : IMessageSerialize 
{
	//金钱奖励
	int _money;	
	//经验奖励
	int _exp;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//金钱奖励
		SerializeUtils.WriteInt(stream, _money);
		//经验奖励
		SerializeUtils.WriteInt(stream, _exp);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//金钱奖励
		_money = SerializeUtils.ReadInt(stream);
		//经验奖励
		_exp = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 金钱奖励
	 */
	public int Money
	{
		set { _money = value; }
	    get { return _money; }
	}
	
	/**
	 * 经验奖励
	 */
	public int Exp
	{
		set { _exp = value; }
	    get { return _exp; }
	}
	
}