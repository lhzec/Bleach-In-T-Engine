using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 响应百万招财积分系统奖池魂玉消息 message
 */
public class ResMillionAccumulateSoulMessage : Message 
{
	//奖池内累计的魂玉数量
	long _soul;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//奖池内累计的魂玉数量
		SerializeUtils.WriteLong(stream, _soul);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//奖池内累计的魂玉数量
		_soul = SerializeUtils.ReadLong(stream);
	}
	
	/**
	 * 奖池内累计的魂玉数量
	 */
	public long Soul
	{
		set { _soul = value; }
	    get { return _soul; }
	}
	
	
	public override int GetId() 
	{
		return 316105;
	}
}